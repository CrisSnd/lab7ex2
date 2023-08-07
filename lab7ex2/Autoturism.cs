using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7ex2
{
    internal class Autoturism
    {
        private string marca;
        private string model;
        private int anFabricatie;
        private Motor motor;
        private Usa usi;


        public Autoturism(string marca, string model, int anFabricatie, Motor motor, Usa usi)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = motor;
            this.usi = usi;
        }


        public void PornesteMotor()
        {
            Console.WriteLine("Masina porneste:");
            motor.PornireMotor();
        }


        public void OpresteMotor()
        {
            Console.WriteLine("Masina se opreste:");
            motor.OprireMotor();
        }

        public string Descriere
        {
            get
            {
                return $"{marca}, {model}, an de fabricatie {anFabricatie},Capaciate cilindrica {motor.CapacitateCilindrica}cmc, {motor.Putere}CP, combustibil {motor.Combustibil},{usi.NumarUsi} usi";

            }
        }
    }
}
