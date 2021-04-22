using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocanuFilipVictor
{
    [Serializable]
   public class Rezervare
    {
        int nr;
        public string[] disponibilitate = new string[30];
        float pret;
        public int ziua;


        public Rezervare(int nr, string[] disponibilitate, float pret, int ziua)
        {
            this.nr = nr;
            this.disponibilitate = disponibilitate;
            this.pret = pret;
            this.ziua = ziua;
        }
        public Rezervare(int nr, float pret, int ziua)
        {
            this.disponibilitate = new string[30];
            this.nr = nr;
            this.pret = pret;
            this.ziua = ziua;
        }

        public int Nr
        {
            get { return this.nr; }
            set { this.nr = value; }
        }
        public float Pret
        {
            get { return this.pret; }
            set { this.pret = value; }
        }

        public override string ToString()
        {
            return "Rezervarea cu numarul " + this.nr + " are pretul " + this.pret + " Lei ";
        }

    }
}
