using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodošli u jednostavan kalkulator!");

            while (true)
            {
                try
                {
                    // Unos prvog broja
                    Console.Write("Unesite prvi broj: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    // Unos operatora
                    Console.Write("Unesite operator (+, -, *, /): ");
                    char op = Console.ReadLine()[0];

                    // Unos drugog broja
                    Console.Write("Unesite drugi broj: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    // Izračunavanje rezultata
                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("Greška: Deljenje sa nulom nije dozvoljeno!");
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("Greška: Nepoznat operator!");
                            continue;
                    }

                    // Prikaz rezultata
                    Console.WriteLine($"Rezultat: {num1} {op} {num2} = {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Greška: Uneli ste nevalidan broj!");
                }

                // Pitamo korisnika da li želi novi kalkulaciju
                while (true)
                {
                    Console.Write("Želite li novi račun? (da/ne): ");
                    string answer = Console.ReadLine().ToLower().Trim();

                    if (answer == "da")
                    {
                        Console.WriteLine();
                        break; // Izlazi iz petlje validacije i nastavlja sa novim računom
                    }
                    else if (answer == "ne")
                    {
                        Console.WriteLine("Hvala što koristite kalkulator. Doviđenja!");
                        //Console.ReadKey();
                        return; // Završava programmm
                    }
                    else
                    {
                        Console.WriteLine("Nevalidan unos. Molimo unesite 'da' ili 'ne'.");
                    }
                }
                
            }

        }
    }
}
