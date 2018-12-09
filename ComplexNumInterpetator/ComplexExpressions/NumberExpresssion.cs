using System.Numerics;

namespace ComplexExpressions
{
    //terminal exression
    public class NumberExpresssion : IExpression
    {
        private string name; //variable name

        public NumberExpresssion(string variableName)
        {
            name = variableName;
        }

        public Complex Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}