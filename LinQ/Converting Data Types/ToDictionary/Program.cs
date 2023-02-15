using Shared;

namespace ToDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            Dictionary<string, Shipping> shippingDictionary = shippings.ToDictionary(x => x.UniqueId);
            shippingDictionary["ABC005"].Start();

            Dictionary<DateTime, List<Shipping>> Dictionary = shippings.GroupBy(x => x.ShippingDate)
                .ToDictionary(s => s.Key, s => s.ToList());
            var date = new DateTime(2023, 3, 9, 0, 0, 0);
            Dictionary[date].Process($"shipping on {date.ToString()}");
        }
    }
}