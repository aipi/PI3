using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3.Play
{
    class Match
    {
        public int[,] trails;

        public Match()
        {
            this.trails = new int[,] { { 0, 2}, { 0, 4 }, { 0, 6 },  { 0, 8 },
                                      { 0, 10 }, { 0, 12 }, { 0, 10 }, { 0, 8 },
                                      { 0, 6 }, { 0, 4 }, { 0, 2 } };
        }

    }
}
