using System;

namespace DoItYourself2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee testEmployee = new Employee("Lam", "Thon", "Thai Binh", 10, 3000);
            Console.WriteLine(testEmployee.ToString());
            Console.WriteLine(testEmployee.calculateTheBonus(2));
        }
    }
}