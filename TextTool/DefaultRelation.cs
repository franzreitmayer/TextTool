using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextTool
{
    class DefaultRelation : IRelation
    {

        private String[] columns = { };
        private String[][] data = { };


        public String[] getColumns()
        {
            return columns;
        }

        public void setColumns(String[] columns)
        {
            this.columns = columns;
        }

        public String[][] getData()
        {
            return data;
        }

        public void setData(String[][] data)
        {
            this.data = data;
        }
    }
}
