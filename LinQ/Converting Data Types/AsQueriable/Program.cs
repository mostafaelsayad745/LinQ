using Shared;

namespace AsQueriable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;
            var todayShipping = shippings.Where(x => x.ShippingDate == DateTime.Today);
            todayShipping.Process("Today's shipping using ShippingList<T> Where");
             
            IQueryable<Shipping> todayShipping1 = shippings.AsQueryable().Where(x => x.ShippingDate == DateTime.Today);
            todayShipping1.Process("Today's shipping using IEnumerable<T> Where");
             Console.WriteLine(todayShipping1.Expression); //  available for IQueryable
        }
    }
    // NOte : expression => give me the code as data
}