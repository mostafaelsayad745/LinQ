using Shared;

namespace AsEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;
            var todayShipping = shippings.Where(x => x.ShippingDate == DateTime.Today);
            todayShipping.Process("Today's shipping using ShippingList<T> Where");

            IEnumerable<Shipping> todayShipping1 = shippings.AsEnumerable().Where(x => x.ShippingDate == DateTime.Today);
            todayShipping1.Process("Today's shipping using IEnumerable<T> Where");
           // Console.WriteLine(todayShipping1.Expression); // not available for IEnumerabel
        }
    }
}