using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextTool
{
    class PlainTextExporter
    {
        private List<PlainItemDescription> itemDescriptions = new List<PlainItemDescription>();

        private IRelation relation = null;

        public PlainTextExporter(List<PlainItemDescription> itemDescriptions, IRelation relation)
        {
            this.itemDescriptions = itemDescriptions;
            this.relation = relation;
        }

        private String generateFormatString(List<PlainItemDescription> itemDesc)
        {
            StringBuilder sb = new StringBuilder();
            for (int i= 0; i < itemDesc.Count; i++)
            {
                PlainItemDescription desc = itemDesc[i];
                sb.Append("{");
                sb.Append(i);
                sb.Append(",");
                sb.Append(desc.align == PlainItemDescription.align_type.left ? "-" : "");
                sb.Append(desc.length());
                sb.Append(":G}");
            }
            String formatString = sb.ToString();
            return formatString;
        }

        public String getText()
        {
            String formatString = generateFormatString(
                this.itemDescriptions);
            StringBuilder sb = new StringBuilder();
            foreach (String[] row in relation.getData())
            {
                String line = String.Format(formatString, row);
                sb.AppendLine(line);
            }
            return sb.ToString();
        }
    }
}
