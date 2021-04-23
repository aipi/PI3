using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3.Play
{
    class Permutation
    {
        public string idDice1 { get; set; }
        public string idDice2 { get; set; }
        public int diceSum { get; set; }

        public void setter(List<int> dice1, List<int> dice2)
        {
            this.idDice1 = dice1[0].ToString();
            this.idDice2 = dice2[0].ToString();
            this.diceSum = Convert.ToInt32(dice1[1]) + Convert.ToInt32(dice2[1]);
        }
    }
    
}
