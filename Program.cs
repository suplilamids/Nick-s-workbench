using System;
namespace Progam
{
    class Program
    {
        static void Main(string[] args)
        {
            char nadaljevanje = 'd';
                
            do
            {
                Console.WriteLine("Prosimo vnesite mejalno izbiro za ( 1 -EUR v GBP,  2 -GBP v EUR, 0 -prekinitev izvajanja ");
                Console.Write("Izbira:  ");
                
                int izbira = int.Parse(Console.ReadLine());

                if (izbira == 1)       // eur v gbp
                {
                    Console.WriteLine();
                    Console.WriteLine("Prosimo vnesite EUR za menjavo v GBP");
                    Console.Write("EUR: ");

                    double eur = double.Parse(Console.ReadLine());
                    double gbp = eur * 0.83;

                    Console.WriteLine();
                    Console.WriteLine("Za " + eur + " EUR se izplača " + gbp + " GBP");

                    int[] denominations = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                    string[] labels =
                    {
                        "100 GBP", "50 GBP", "20 GBP", "10 GBP", "5 GBP", "2 GBP", "1 GBP", "50 penija", "20 penija",
                        "10 penija", "5 penija", "2 penija", "1 penij"
                    };

                    Console.WriteLine("GBP: ");

                    int pennies = (int)(gbp * 100);
                    for (int i = 0; i < denominations.Length; i++)
                    {
                        int count = pennies / denominations[i];
                        if (count > 0)
                        {
                            Console.WriteLine($"{labels[i]}: {count}");
                            pennies %= denominations[i];
                        }
                    }

                
                    Console.WriteLine();
                    Console.WriteLine("Ali zelite opraviti ponovno menjavo");
                    Console.Write("d za DA, n za NE:  ");
                    nadaljevanje = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                
                if (izbira == 2)     //  gbp v eur
                {
                    Console.WriteLine();
                    Console.WriteLine("Prosimo vnesite EUR za menjavo v GBP");
                    Console.Write("EUR: ");

                    double eur = double.Parse(Console.ReadLine());
                    double gbp = eur * 0.83;

                    Console.WriteLine();
                    Console.WriteLine("Za " + eur + " EUR se izplača " + gbp.ToString("0.00") + " GBP");

                    int[] denominations = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                    string[] labels =
                    {
                        "100 GBP", "50 GBP", "20 GBP", "10 GBP", "5 GBP", "2 GBP", "1 GBP", "50 penijev", "20 penijev",
                        "10 penijev", "5 penijev", "2 penija", "1 penij"
                    };

                    Console.WriteLine("GBP: ");

                    
                    int pennies = (int)Math.Round(gbp * 100);
                    for (int i = 0; i < denominations.Length; i++)
                    {
                        int count = pennies / denominations[i];
                        if (count > 0)
                        {
                            Console.WriteLine($"{labels[i]}: {count}");
                            pennies %= denominations[i];
                        }
                    }
                    
                    
                
                    Console.WriteLine();
                    Console.WriteLine("Ali zelite opraviti ponovno menjavo");
                    Console.Write("d za DA, n za NE:  ");
                    nadaljevanje = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                
                if (izbira == 0)  // prekinitev izvajanja
                {
                    Console.WriteLine();
                    Console.WriteLine("Hvala in nasvidenje.");
                    
                    Console.WriteLine();
                    Console.WriteLine("Ali zelite opraviti ponovno menjavo");
                    Console.Write("d za DA, n za NE:  ");
                    nadaljevanje = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    
                }
                
                
            } while (nadaljevanje == 'd');
        }
    }
}