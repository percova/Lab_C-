using System.Numerics;

namespace ComplexExpressions
{
    //  nonterminal expression for multiplication
    public class MultiplyExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public MultiplyExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public Complex Interpret(Context context)
        {
            return leftExpression.Interpret(context) * rightExpression.Interpret(context);
        }
    }
}