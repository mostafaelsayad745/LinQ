using Shared;

namespace lookUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            ILookup<string, Shipping> shippingDictionary = shippings.ToLookup(x => x.UniqueId);
            shippingDictionary["ABC005"].First().Start();

            ILookup<DateTime, Shipping> Dictionary = shippings.ToLookup(x => x.ShippingDate);
            var date = new DateTime(2023, 3, 9, 0, 0, 0);
            Dictionary[date].Process($"shipping on {date.ToString()}");
        }
    }
}