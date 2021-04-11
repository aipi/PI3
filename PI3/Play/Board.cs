using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3.Play
{
    class Board
    {
        public int trilha { get; set; }
        public int position { get; set; }
        public string gamerID { get; set; }
        public string type { get; set; }

        public void setter(string line)
        {
            string[] column = line.Split(',');
            this.trilha = 1 < column.Length ? Convert.ToInt32(column[0]) - 2 : 0;
            this.position = 1 < column.Length ? Convert.ToInt32(column[1]) : 0;
            this.gamerID = 1 < column.Length ? column[2] : "";
            this.type = 1 < column.Length ? column[3] : "";
        }

    }
}
