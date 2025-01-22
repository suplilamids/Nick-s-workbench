using System;

namespace HelloWorld
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            char nadaljevanje = 'y';
            do
            {
                Console.WriteLine("Write a number between 10 and 1000 .");
                int stevilo = int.Parse(Console.ReadLine());
                
                Console.WriteLine();
                Console.WriteLine("Input: " + stevilo);
                Console.WriteLine();

                
                //logic for number of devisors
                int steviloDeliteljev = StejeDelitelje(stevilo);
                Console.WriteLine("The number of divisors: " + steviloDeliteljev);
                Console.WriteLine();
                
                //logic for writing all deviders
                List<int> delitelji = VsiDelitelji(stevilo);
                Console.WriteLine("Deviders for number " + stevilo + " are:   " + string.Join(", ", delitelji));
                Console.WriteLine();
                
                //logic for prime number
                bool prastevilo = PraSteviloAliNe(stevilo);
                if (prastevilo == true)
                {
                    Console.WriteLine("The number is PRIME NUMBER.");
                }
                else if (prastevilo == false)
                {
                    Console.WriteLine("The number is not PRIME NUMBER.");
                }
                Console.WriteLine();
                
                //Special PRIME NUMBER

                bool posebnoPrastevilo = PosebnoPraAliNe(stevilo);
                if (posebnoPrastevilo == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("The number is SPECIAL PRIME NUMBER.");
                    Console.WriteLine("A Prime Number is a Special Prime Number when we can add two consecutive Prime Numbers + 1 and obtain the given Prime Number.");
                    Console.WriteLine();
                   
                }
                else if (posebnoPrastevilo == false)
                {
                    Console.WriteLine("The number is not SPECIAL PRIME NUMBER.");
                    Console.WriteLine();
                }
                Console.WriteLine();
                
                
                
                //logic for loop continue
                Console.WriteLine();
                Console.WriteLine("Do you want to continue?");
                Console.Write("y for YES, n for NO:  ");
                nadaljevanje = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


            } while (nadaljevanje == 'y');
        }

        static int StejeDelitelje(int stevilo)
        {
            int stetje = 0;
            for (int i = 1; i <= stevilo; i++)
            {
                if (stevilo % i == 0)
                {
                    stetje++;
                }
            }
            return stetje;
        }


        static List<int> VsiDelitelji(int stevilo)
        {
            List<int> delitelji = new List<int>();
            for (int i = 1; i <= stevilo; i++)
            {
                if (stevilo % i == 0)
                {
                    delitelji.Add(i);
                }
            }
            return delitelji;
        }


        static bool PraSteviloAliNe(int stevilo)
        {
            if (stevilo < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(stevilo); i++)
            {
                if (stevilo % i == 0)
                    return false;
            }
            return true;
        }


        static bool PosebnoPraAliNe(int stevilo)
        {
            // First check if the number is a prime number
            if (!PraSteviloAliNe(stevilo))
                return false;

            // Find all prime numbers smaller than the number
            List<int> prastevila = NajdiVsaPrastevila(stevilo);

            // Check consecutive prime pairs
            for (int i = 0; i < prastevila.Count - 1; i++)
            {
                if (prastevila[i] + prastevila[i + 1] + 1 == stevilo)
                {
                    Console.WriteLine($"Note: This is a special prime number because the numbers {prastevila[i]} + {prastevila[i + 1]} + 1 equal {stevilo}.");
                    return true;
                }
            }

            return false;
        }

        static List<int> NajdiVsaPrastevila(int max)
        {
            List<int> prastevila = new List<int>();
            for (int i = 2; i < max; i++)
            {
                if (PraSteviloAliNe(i))
                {
                    prastevila.Add(i);
                }
            }
            return prastevila;
        }
        
    }
}






























