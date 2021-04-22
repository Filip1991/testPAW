using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocanuFilipVictor
{
   public class Gestiune
    {
        public Rezervare[] vect;

        public Gestiune()
        {
            this.vect = new Rezervare[0];
        }
        public Gestiune(Rezervare[] vect)
        {
            this.vect = vect;
        }

        public static Gestiune operator +(Gestiune g, Rezervare r)
        {
            Rezervare[] cop = new Rezervare[g.vect.Length + 1];
            for (int i = 0; i < g.vect.Length; i++)
                cop[i] = g.vect[i];
            cop[g.vect.Length] = r;
            g.vect = cop;
            return g;

        }

        public static Gestiune operator -(Gestiune g, Rezervare r)
        {

            Gestiune t = new Gestiune();
            for (int i = 0; i < g.vect.Length; i++)
                if (g.vect[i] != r)
                    t += g.vect[i];
            g = t;
            return g;




        }
    }
}
