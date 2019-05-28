using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WłasnyProjekt
{
    public class Exercise
    {
        public string Name { get; set; }
        public List<Set> sets = new List<Set>();
        
    }

    public class Set
    {
        public uint Nr { get; set; }
        public uint Reps { get; set; }

        public Set(uint Nr, uint Reps)
        {
            this.Nr = Nr;
            this.Reps = Reps;
        }
    }

}
