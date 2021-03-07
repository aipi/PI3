using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3
{
    class Match
    {
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string status { get; set; }
        public void setter(string line)
        {
            string[] column = line.Split(',');
            this.id = Convert.ToInt32(column[0]);
            this.name = column[1];
            this.date = column[2];
            this.status = column[3];
        }

    }
}
