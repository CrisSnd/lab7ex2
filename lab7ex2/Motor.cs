using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7ex2
{
    internal class Motor
    {
        int capacitateCilindrica;
        int putere;
        string tipCombustibil;
       

        public Motor(int cc, int p, string combust)
        {
            this.capacitateCilindrica=cc;
            this. putere=p;
            this.tipCombustibil=combust;
            
        }


        public int CapacitateCilindrica
        {
            get
            {
                return capacitateCilindrica;
            }
        }

        public int Putere
        {
            get
            {
                return putere;
            }
        }


        public string Combustibil
        {
            get
            {
                return tipCombustibil;
            }
        }


        public void PornireMotor()
        {
            Console.WriteLine("bar bar bar");
        }
        

        public void OprireMotor()
        {
            Console.WriteLine("par poc pac");
        }
        


    }

}
