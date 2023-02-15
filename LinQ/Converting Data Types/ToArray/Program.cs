using Shared;

namespace ToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            var ShippingArray = shippings.ToArray();
            Console.WriteLine($"total shippings are {ShippingArray.Length}");
            Console.WriteLine($"first shipping");
            ShippingArray[0].Start();
            Console.ReadKey();
        }
    }
}