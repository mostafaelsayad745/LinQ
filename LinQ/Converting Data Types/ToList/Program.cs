using Shared;

namespace ToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            var ShippingList = shippings.ToList();
            Console.WriteLine($"total shippings are {ShippingList.Count}");
            Console.WriteLine($"first shipping");
            ShippingList[0].Start();
            ShippingList.First().Start();
            Console.ReadKey();
        }
    }
}