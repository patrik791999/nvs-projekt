using System;
using System.Collections.Generic;

namespace troj
{
    class vektor //[0,0][6,0][0,8]
    {
        public int u;
        public int v;
        // >>3x//
        public vektor()
        {
            this.u = zadajVektor();
            this.v = zadajVektor();
            vypisVekt();
        }
        public int zadajVektor()
        {
            Console.WriteLine("zadaj cislo");
            int x = 0;
            while (true)
            {
                bool xjec = int.TryParse(Console.ReadLine(), out x);
                if (!xjec)
                {
                    Console.WriteLine("neni čislo, zadaj znova");
                }
                else
                    break;
            }
            return x;
        }
        public void vypisVekt()
        {
            Console.WriteLine($"[{this.u}, {this.v}]");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, vektor> vektory = new Dictionary<string, vektor>()
            {
                {"A", new vektor()},
                {"B", new vektor()},
                {"C", new vektor()}
            };

            foreach (var dic in vektory)
            {
                Console.WriteLine($"{dic.Key} [{dic.Value.u},{dic.Value.v}]");
            }

            double a = Math.Sqrt(Math.Pow((vektory["C"].u - vektory["B"].u), 2) + Math.Pow((vektory["C"].v - vektory["B"].v), 2));
            double b = Math.Sqrt(Math.Pow((vektory["C"].u - vektory["A"].u), 2) + Math.Pow((vektory["C"].v - vektory["A"].v), 2));
            double c = Math.Sqrt(Math.Pow((vektory["A"].u - vektory["B"].u), 2) + Math.Pow((vektory["A"].v - vektory["B"].v), 2));

            Console.WriteLine($"strana a:{a},strana b:{b},strana c:{c}");

            if (a + b > c || a + c > b || c + b > a)
            {
                Console.WriteLine("trojuholník je zostrojitelný");
                double o = a + b + c;
                double s = o / 2;
                double S = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine($"obvod:{o}  pol/obvod:{s}  obsah:{S}");
                if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                {
                    Console.WriteLine("je pravouhlý");
                }
                else
                {
                    Console.WriteLine("neni pravouhlý");
                }
            }
            else
            {
                Console.WriteLine("nenei zostrojitelný");
            }

            
            Console.ReadKey();

        }
    }
}
