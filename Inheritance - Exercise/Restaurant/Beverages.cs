

namespace Restaurant
{
    public class Beverages : Product
    {
        public Beverages(string name, decimal price, double mililiters) : base(name, price)
        {
            Mililiters= mililiters;
        }

        public double Mililiters { get; set; }
    }
}
