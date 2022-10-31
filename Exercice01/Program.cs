using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01
{
    internal class Program
    {
        void prime_num(int num)
        {
            bool EstPremier = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                float rest = num % i;
                if (rest == 0)
                {
                    EstPremier = false;
                    break;
                }
            }
            if (EstPremier)
            {
                Console.WriteLine("le nombre est premier ");
            }
            else
            {
                Console.WriteLine("le nombre n'est pas premier");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("veuillez saisir un nombre");
            string nombre = Console.ReadLine();
            int nb = int.Parse(nombre);
            p.prime_num(nb);
            Console.ReadLine();
        }
    }
}
