using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Record
    {
        public int id { get; set; }
        public int id_Book { get; set; }
        public int id_Reader { get; set; }
        public DateTime dateOfIssue { get; set; }
        public DateTime dateRelease { get; set; }
    }
}
