using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare a Car object reference named myCar
            Cars myCar;
// create a Car object, and assign its address to myCar
            Console.WriteLine("Creating a Car object and assigning " + "its memory location to myCar");
            myCar = new Cars();

// assign values to the Car object's fields using myCar
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

// display the field values using myCar
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = "+ myCar.make);
            Console.WriteLine("myCar.model= "+myCar.model);
            Console.WriteLine("myCar.color = "+myCar.color);
            Console.WriteLine("myCar.yearBuilt=" +myCar.yearBuilt);

// call the methods using myCar
            myCar.Start();
            myCar.Stop();

// declare another Car object reference and
// create another Car object
            Console.WriteLine("Creating another Car object and"+"assigning its memory location to redPorsche");
            Cars redPorsche = new Cars();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            Console.WriteLine("redPorsche is a " + redPorsche.model);
//change the object referenced by the myCar object //reference to the object referenced by redPorshe
            Console.WriteLine("Assigning redPorsche to  myCar");
            myCar = redPorsche;
            Console.WriteLine("myCar details:");
            Console.WriteLine("myCar.make = " + myCar.make);
            Console.WriteLine("myCar.model = " +myCar.model);
            Console.WriteLine("myCar.color = " +myCar.color);
            Console.WriteLine("myCar.yearBuilt = "+myCar.yearBuilt);
// assign null to myCar (myCar will no longer reference 
//an object)
            myCar = null;
            Console.ReadLine();

        }
    }
}