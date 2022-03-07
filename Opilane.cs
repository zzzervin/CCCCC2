using Class_c_sharp;
using System;
using System.Collections.Generic;
using System.Text;


namespace CCCCC2
{
    class Opilane : Inimene
    {
        string ruhm;
        double hinne;
        bool toetus;

        public Opilane() { }

        public Opilane(string Eesnimi, string Perekonanimi, string Ruhm) : base(Eesnimi, Perekonanimi)
        {
            ruhm = Ruhm;
        }
        public string Ruhm 
        {
            set { ruhm = value; }
            get { return ruhm; }
        }

        public double Hinne
        {
            set
            {  if (value > 1 && value < 5) hinne = value;}
            get { return hinne; }
        }

        public bool Toestus
        {
            get
            {
                if (hinne > 3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }

        public void Info()
        {
            string t = "";
            Console.WriteLine($"Minu nimi on {Eesnimi},{Perekonanimi} ");
            if (Toestus == true)
            {
                t = "Saan toetust";
            }
            else if (Toestus == false)
            {
                t = "Saan toetust";
            }
            else
            {
                t = "Saan toetust";
            }
        }
        
    }

    
}
