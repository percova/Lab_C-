using System.Collections.Generic;
using System.Numerics;

namespace ComplexExpressions
{
    public class Context
    {
        private Dictionary<string, Complex> variables;

        public Context()
        {
            variables = new Dictionary<string, Complex>();
        }

        // get value of the variable by name
        public Complex GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, Complex num)
        {
            if (variables.ContainsKey(name))
            {
                variables[name] = num;
            }
            else
            {
                variables.Add(name, num);    
            }
        }
    }
}