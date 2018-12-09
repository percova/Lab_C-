using System.Numerics;

namespace ComplexExpressions
{
    // interpetator interface
    public interface IExpression
    {
        Complex Interpret(Context context);
    }
}