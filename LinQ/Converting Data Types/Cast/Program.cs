using Shared;

namespace Cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shipping = ShippingRepository.AllAsList;

            var groundShipping = shipping.Where(x => x.GetType()== typeof(GroundShipping)).Cast<GroundShipping>();
            groundShipping.Process("Ground Shipping");

            Console.ReadKey();
        }
    }

    public static class SampleExtension
    {
        public static IEnumerable<T> Cast<T> (this IEnumerable<T> Source)
        {
            foreach(var item in Source)
                yield return (T)item;
        }
    }
}