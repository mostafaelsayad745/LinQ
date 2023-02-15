using Shared;

namespace OfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                IEnumerable<Shipping> shipping = ShippingRepository.AllAsList;

                var groundShipping = shipping.OfType<GroundShipping>(); // it makes safe cast you don't need where
                groundShipping.Process("Ground Shipping");

                Console.ReadKey();
            
        }
    }

        //public static class SampleExtension
        //{
        //    public static IEnumerable<T> Cast<T>(this IEnumerable<T> Source)
        //    {
        //        foreach (var item in Source)
        //        {
        //               if (item is T)
        //                  yield return (T)item;
        //        }
        //    }
        //}
}