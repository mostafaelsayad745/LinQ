using System.Linq.Expressions;

namespace Expression_Trees_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, bool>> IsNegativeExpression = num => num < 0;

            ParameterExpression numParam =IsNegativeExpression.Parameters[0];
            BinaryExpression operation = (BinaryExpression)IsNegativeExpression.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            Console.WriteLine($"{numParam.Name} => {left.Name} {operation.NodeType} {right.Value}");

        }
    }
}