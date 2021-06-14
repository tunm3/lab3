namespace ConsoleApplication1
{
    public class Cars
    {
        // declare the fields
        public string make;
        public string model;
        public string color;

        public int yearBuilt;

        // define the methods
        public void Start()
        {
            System.Console.WriteLine(model + " started");
        }

        public void Stop()
        {
            System.Console.WriteLine(model + " stopped");
        }
    }
}