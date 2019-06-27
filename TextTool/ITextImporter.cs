using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextTool
{
    interface ITextImporter
    {
        IRelation createRelationFromText(String text);
    }
}
