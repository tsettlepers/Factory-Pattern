namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vehicle creator...");
            Console.WriteLine("Enter the number of wheels on your desired vehicle:");
            string userInput = Console.ReadLine();

            IVehicle newV = VehicleFactory.GetVehicle(userInput);
            newV.Drive();
        }
    }
}
