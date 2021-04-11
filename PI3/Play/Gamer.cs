using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3
{
    class Gamer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public void setter(string line)
        {
            string[] column = line.Split(',');
            this.id = 0 < column.Length ? column[0] : "";
            this.name = 1 < column.Length ? column[1] : "";
            this.color = 2 < column.Length ? column[2] : "";
        }

    }
}
