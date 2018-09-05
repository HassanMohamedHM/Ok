using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer
{
    public class TableHeader
    {
        public string ColumnName { get; set; }
        public string ArabicCaption { get; set; }
        public string EnglishCaption { get; set; }
        public Type DataType { get; set; }
    }
}
