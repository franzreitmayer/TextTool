using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextTool
{
    class PlainTextImporter : ITextImporter
    {
        public List<PlainItemDescription> itemDescriptions = new List<PlainItemDescription>();

        public String relationID = "";

        public String[] columnNames = { };


        private void evaluateColumnNames()
        {
            columnNames = new String[itemDescriptions.Count];
            for (int i = 0; i < itemDescriptions.Count; i++)
            {
                columnNames[i] = itemDescriptions.ElementAt(i).columnId;
            }
        }

        public IRelation createRelationFromText(string text)
        {
            evaluateColumnNames();
            String[] lines = text.Split('\n');
            String[][] dataArray = new String[lines.Count()][];
            PlainItemDescription[] idesc = itemDescriptions.ToArray();
            for (int lineIndex = 0; lineIndex < lines.Count(); lineIndex++) 
            {
                String textLine = lines[lineIndex];
                String[] row = new String[columnNames.Count()];
                for (int columnIndex = 0; columnIndex < idesc.Count(); columnIndex++)
                {
                    int length = idesc[columnIndex].length();
                    if (textLine.Length >= idesc[columnIndex].from - 1 + length)
                    {
                        //dataArray[lineIndex, columnIndex] =
                        //    textLine.Substring(idesc[columnIndex].from - 1, length);
                        int index = idesc[columnIndex].from - 1;
                        row[columnIndex] = 
                            textLine.Substring(index, length).Trim();
                    }
                }
                dataArray[lineIndex] = row;
            }
            DefaultRelation defaultRelation = new DefaultRelation();
            defaultRelation.setColumns(columnNames);
            defaultRelation.setData(dataArray);
            return defaultRelation;
        }
    }
}
