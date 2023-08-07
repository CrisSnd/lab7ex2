using lab7ex2;
using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* • Un autoturism detine un motor precum si un numar de usi. De asemenea autovehiculul este caracterizat de marca, model si an de fabricatie.
                         • Motorul este caracterizat de:
                                    - Capacitate cilindrica;
                                    - Putere;
                                    - Tipul combustibilului;
                              • Detine functii pentru:
                                  - Pornirea motorului; la apelul acestei functii motorul va afisa in consola “brr”;
                                  - Oprire a motorului; la apelul acestei functii motorul va afisa in consola “par poc pac”;

                         • Usa va detina doua metode:
                                 - Deschide; La apelul acestei metode usa va afisa in consola “click”;
                                 - Inchide; La apelul acestei metode usa va afisa in consola “clack”;

              • Autoturismul va avea urmatoarele metode/proprietati:
                   - GetDescription; Va returna descrierea completa a autovehicolului sub forma unui sir de caractere “Marca, model, anDeFabricatie, capacitate cilindrica, combustibil, putere motor, numar de usi.
                   - Porneste masina; Va afisa textul “masina porneste”, va inchide usile si va porni motorul;
                   -  Opreste masina; Va afisa textul “masina se opreste”, va opri motorul si va inchide usile;
             
        In metoda Main, creati autoturisme, afisati-le descrierea, apelati functiile de pornire/oprire ale acestora.
        Creati diagrama UML si salvati-o in git, alaturi de proiect. */



            Motor motor = new Motor(1298, 75, "benzina");
            Usa usi = new Usa(4);

            Autoturism auto = new Autoturism("Dacia", "Logan", 2020, motor, usi);

            Console.WriteLine(auto.Descriere);

            Console.WriteLine("Usa se deschide:"); 
            usi.DeschideUsa();

            Console.WriteLine("Usa se inchide:");
            usi.InchideUsa();

            auto.PornesteMotor();
            auto.OpresteMotor();

        }
    }
}
          