using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3.Play
{
    class Options
    {
        public List<Permutation> permutations { get; set; }
        public string options { get; set; }

        public void setter(List<Permutation> permutations, string options)
        {
            this.permutations = permutations;
            this.options = options;
        }
    }

}
