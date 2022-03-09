using Class_c_sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CCCCC2
{
    public class Opetaja : Inimene
    {
        string aine;
        public Opetaja() { }
        public string Aine
        {
            set { aine = value; }
            get { return aine; }
        }

        public override void KAS_ma_olen()
        {
            Console.WriteLine("Ma olen õpetaja");
        }

        public override void Vana()
        {
            throw new NotImplementedException();
        }
    }
}
