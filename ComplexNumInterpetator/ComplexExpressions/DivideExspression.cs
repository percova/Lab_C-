using System.Numerics;

namespace ComplexExpressions
{
    // nonterminal expression for devisione
    public class DivideExspression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public DivideExspression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public Complex Interpret(Context context)
        {
            return leftExpression.Interpret(context) / rightExpression.Interpret(context);
        }
    }
}