using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextTool
{
    interface IRelation
    {
        String[] getColumns();
        void setColumns(String[] columns);
        String[][] getData();
        void setData(String[][] data);
    }
}
