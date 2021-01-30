using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Num
    {
        public Num (double chislo)
        {
            this.chislo = chislo;
        }
        public double chislo { get; set; }
        public bool DvaZnach() 
        {
            if (chislo > 9 && chislo < 100)
                return true;
            else return false;
        }
    }
}
