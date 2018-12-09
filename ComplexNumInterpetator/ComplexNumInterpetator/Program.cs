using System;
using System.Diagnostics;
using System.Dynamic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using ComplexExpressions;
using Context = ComplexExpressions.Context;

namespace ComplexNumInterpetator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();
            
            // define set of variables
            Complex x  = new Complex(15, 9);
            Complex y = new Complex(5, 3);
            
            // add variables to context
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            
            // Object to calcute sum
            IExpression additionExpression = new AddExpression(new NumberExpresssion("x"), new NumberExpresssion("y"));
            Complex sum = additionExpression.Interpret(context);
            Console.WriteLine(sum);
            
            // Object to calcute difference
            IExpression substractionExpression = new SubtractExpression(new NumberExpresssion("x"), new NumberExpresssion("y"));
            Complex difference = substractionExpression.Interpret(context);
            Console.WriteLine(difference);

            // Object to calculate product
            IExpression multiplicationExpression = new MultiplyExpression(new NumberExpresssion("x"), new NumberExpresssion("y"));
            Complex product = multiplicationExpression.Interpret(context);
            Console.WriteLine(product);
            
            // Object to calculate quotient
            IExpression divisionExpression = new DivideExspression(new NumberExpresssion("x"), new NumberExpresssion("y"));
            Complex quotient = divisionExpression.Interpret(context);
            Console.WriteLine(quotient);

            Console.Read();
        }
    }
}