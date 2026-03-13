using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026310a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mihajlo Glavan
            tacka a = new tacka(1, 1);
            Console.WriteLine(a.ugao());
            Console.WriteLine(a.d());
            tacka A = new tacka(3, 1);
            tacka B = new tacka(-1, 3);
            tacka C = new tacka(3, 3);
            vektor OA = new vektor(A);
            vektor OB = new vektor(B);
            vektor AC = new vektor(A, C);
            Console.WriteLine(vektor.SP(OA, OB));
            Console.ReadKey();
        }
    }
}
