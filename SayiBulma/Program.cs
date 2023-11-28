using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiBul sayiBul = new SayiBul();
            double bs=sayiBul.SayiyiSec(4, 40);
            Console.WriteLine( "Büyük Sayi:{0}",bs);
        }
    }
    public class SayiBul
    {
        public double SayiyiSec(double sayi1, double sayi2)
        {
            double sonuc = 0;
            if (sayi1 >= sayi2)
            {
                sonuc=sayi1;
            }
            else
            {
                sonuc=sayi2;
            }
            if (sayi1 == sayi2)
            {
                sayi1=sayi2;
            }
            return sonuc;

        }
    }
}
