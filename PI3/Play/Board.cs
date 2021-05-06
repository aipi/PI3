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

        public bool isComplete { get; set; }

        public void setter(string line)
        {
            string[] column = line.Split(',');
            this.trilha = 1 < column.Length ? Convert.ToInt32(column[0]) - 2 : 0;
            this.position = 1 < column.Length ? Convert.ToInt32(column[1]) : 0;
            this.gamerID = 1 < column.Length ? column[2] : "";
            this.type = 1 < column.Length ? column[3] : "";
            if ((this.trilha == 2 || this.trilha == 12) && this.position == 2)
                this.isComplete = true;
            else if ((this.trilha == 3 || this.trilha == 11) && this.position == 4)
                this.isComplete = true;
            else if ((this.trilha == 4 || this.trilha == 10) && this.position == 6)
                this.isComplete = true;
            else if ((this.trilha == 5 || this.trilha == 9) && this.position == 8)
                this.isComplete = true;
            else if ((this.trilha == 6 || this.trilha == 8) && this.position == 10)
                this.isComplete = true;
            else if (this.trilha == 7 && this.position == 12)
                this.isComplete = true;
        }

    }
}
