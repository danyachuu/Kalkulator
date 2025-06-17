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
                    // Unos prvog broja sa validacijom
                    double num1;
                    while (true)
                    {
                        Console.Write("Unesite prvi broj: ");
                        if (double.TryParse(Console.ReadLine(), out num1))
                            break;
                        Console.WriteLine("Nevalidan unos. Molimo unesite broj.");
                    }

                    // Unos operatora sa validacijom
                    char op;
                    while (true)
                    {
                        Console.Write("Unesite operator (+, -, *, /): ");
                        string input = Console.ReadLine();
                        if (input.Length == 1 && "+-*/".Contains(input))
                        {
                            op = input[0];
                            break;
                        }
                        Console.WriteLine("Nevalidan operator. Molimo unesite +, -, * ili /.");
                    }

                    // Unos drugog broja sa validacijom
                    double num2;
                    while (true)
                    {
                        Console.Write("Unesite drugi broj: ");
                        if (double.TryParse(Console.ReadLine(), out num2))
                            break;
                        Console.WriteLine("Nevalidan unos. Molimo unesite broj.");
                    }


                    double result = 0;
                    bool validOperation = true;

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
                                Console.WriteLine("Greška: Dijeljenje sa nulom nije dozvoljeno!");
                                validOperation = false;
                            }
                            break;
                    }

                    if (validOperation)
                    {
                        Console.WriteLine($"Rezultat: {num1} {op} {num2} = {result}");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Došlo je do neočekivane greške: {ex.Message}");
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
                        Console.ReadKey();
                        return; // Završava program
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
