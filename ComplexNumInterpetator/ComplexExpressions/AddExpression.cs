using System.Linq.Expressions;
using System.Numerics;

namespace ComplexExpressions
{
    // nonterminal expression for addition
    public class AddExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public Complex Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}