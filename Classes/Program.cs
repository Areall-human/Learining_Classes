namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //creates an instance/object of car, it executes all the coee in the summoned class
            Car audi = new Car("Audi", "A3", true);


            Car bmw = new Car("BMW", "M4", false);


            Console.WriteLine("please enter the brand name");
            //Brand setting 
            audi.Brand = Console.ReadLine();
            //Brand getting
            Console.WriteLine("you entered " + audi.Brand);

            
        }
    }
}
