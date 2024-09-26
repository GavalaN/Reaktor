using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaktorConApp
{
    class AtomReaktor
    {
        static Random rnd = new Random();
        static int hom;
        static double aram;
        

        public int Hom { get => Hom; private set => rnd.Next(40, 101); }
        public double Aram { get => aram; set => aram = rnd.NextDouble() * (2.5 - 1) + 1; }
        

        public static bool Leallitas()
        {
            if (hom>=70)
            {
                //bumm
                return false;
            }
            else
            {
                return  true;
            }
        }
        public void HutovizBenged() 
        {
            hom = 40;
        }
        public void GenealtEnergia()
        {
            Aram= rnd.NextDouble()*(aram*2-aram)+aram;
        }

  

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
