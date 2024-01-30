namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar supra = new SportCar(100, 70);
            supra.Drive(10);

            System.Console.WriteLine(supra.Fuel);
        }
    }
}
