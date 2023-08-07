using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7ex2
{
    internal class Usa
    { 
   
     private int usi;
  

        public Usa(int nrUsi)
        {
        this.usi = nrUsi;
        }

        public int NumarUsi
        {
            get
            {
                return usi;
            }
        }


        public void DeschideUsa()
        {
            Console.WriteLine("click");
        }

        public void InchideUsa()
        {
            Console.WriteLine("clack");
        }
    }

}
