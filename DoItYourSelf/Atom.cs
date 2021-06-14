using System;

namespace DoItYourSelf
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string FullName { get; set; }
        public float weight { get; set; }

        public bool Accept()
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter atomic number : ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        Number = number;
                        if (Number == 0)
                        {
                            return false;
                        }

                        break;
                    }
                }

                Console.Write("Enter symbol : ");
                Symbol = Console.ReadLine();
                Console.Write("Enter full name : ");
                FullName = Console.ReadLine();
                while (true)
                {
                    Console.Write("Enter atomic weight : ");
                    if (float.TryParse(Console.ReadLine(), out var number))
                    {
                        weight = number;
                        break;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{Number} {Symbol} {FullName} {weight}");
        }
    }
}