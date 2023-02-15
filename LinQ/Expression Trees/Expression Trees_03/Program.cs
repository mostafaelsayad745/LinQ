using System.Linq.Expressions;

namespace Expression_Trees_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(num) => num % 2 == 0;

            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression constantExpression0 = Expression.Constant(0, typeof(int));
            ConstantExpression constantExpression2 = Expression.Constant(2, typeof(int));

            BinaryExpression ModuloBinaryExpression = Expression.Modulo(numParam, constantExpression2);
            BinaryExpression EqualBinaryExpression =
                Expression.Equal(ModuloBinaryExpression, constantExpression0);

            Expression<Func<int, bool>> isEvenExpression =
                Expression.Lambda<Func<int, bool>>(EqualBinaryExpression, numParam);



            var isEven = isEvenExpression.Compile();
            Console.WriteLine(isEven(10));
            Console.WriteLine(isEven(9));

        }
    }
}