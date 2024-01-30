namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var bear = new Bear("Mecho");

            System.Console.WriteLine(bear.Name);
        }
    }
}