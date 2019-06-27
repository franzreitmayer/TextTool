using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using TextTableTool;

namespace TextTool
{
    class TextTableProcessor
    {
        private String textTableScript = "";

        private String text = "";

        public TextTableProcessor(String textTableScript, String text)
        {
            this.textTableScript = textTableScript;
            this.text = text;
        }

        public IRelation process()
        {
            CommonTree root = parse();
            IRelation relation = null;
            switch (root.Token.Type)
            {
                case TextTableParser.PLAIN_FILE:
                    relation = processPlainFile(root);
                break;

            }
            return relation;
        }

        public String process(IRelation relation)
        {
            CommonTree root = parse();
            List<PlainItemDescription> idesc = evaluatePlainItemDescription(ref root);
            PlainTextExporter exporter = new PlainTextExporter(idesc, relation);
            String text = exporter.getText();
            return text;

        }

        private IRelation processPlainFile(CommonTree root)
        {
            List<PlainItemDescription> idesc = evaluatePlainItemDescription(ref root);
            PlainTextImporter importer = new PlainTextImporter();
            importer.relationID = "";
            //importer.columnNames = names;
            importer.itemDescriptions = idesc;
            IRelation relation = importer.createRelationFromText(text);
            return relation;
        }

        private List<PlainItemDescription> evaluatePlainItemDescription(ref CommonTree root)
        {
            IList<ITree> parseTreeChildren = ((CommonTree)root.GetChild(1)).Children;
            List<PlainItemDescription> idesc = new List<PlainItemDescription>();
            PlainItemDescription lastItem = null;
            String[] names = new String[parseTreeChildren.Count];
            for (int i = 0; i < parseTreeChildren.Count; i++)
            {
                PlainItemDescription descr = new PlainItemDescription();
                CommonTree element = (CommonTree)parseTreeChildren[i];
                descr.columnId = element.Text;
                names[i] = descr.columnId;
                if (element.ChildCount == 1 || (element.ChildCount == 2 && element.GetChild(1).Type != TextTableParser.INT))
                {
                    int length = Int16.Parse(element.GetChild(0).Text);
                    if (i == 0)
                    {
                        descr.from = 1;
                        descr.to = length;
                    }
                    else
                    {
                        descr.from = lastItem.to + 1;
                        descr.to = descr.from + length - 1;
                    }
                }
                else
                {
                    descr.from = Int16.Parse(element.GetChild(0).Text);
                    descr.to = Int16.Parse(element.GetChild(1).Text);
                }

                if (element.GetChild(element.ChildCount - 1).Type != TextTableParser.INT)
                {
                    if (element.GetChild(element.ChildCount - 1).Type == TextTableParser.ALIGN_RIGHT)
                    {
                        descr.align = PlainItemDescription.align_type.right;
                    }
                }
                lastItem = descr;
                idesc.Add(descr);
            }
            return idesc;
        }

        private CommonTree parse()
        {
            ANTLRStringStream stringStream = new ANTLRStringStream(textTableScript);
            TextTableLexer lexer = new TextTableLexer(stringStream);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            TextTableParser parser = new TextTableParser(tokenStream);
            CommonTree tree = (CommonTree)parser.table_desc().Tree;
            return tree;
        }
    }
}
