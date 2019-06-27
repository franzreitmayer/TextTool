using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextTool
{
    class PlainItemDescription
    {
        public enum align_type { right, left };
        public int from = 0;
        public int to = 0;
        public String columnId = "";
        public align_type align = align_type.left;
        public int length()
        {
            return to - from + 1;
        }
    }
}
