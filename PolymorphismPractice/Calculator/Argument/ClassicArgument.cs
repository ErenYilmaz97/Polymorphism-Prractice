using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.Argument
{
    public class ClassicArgument : IArgument
    {
        public List<decimal> Arguments { get; }
        public int GetArgumentCount { get => this.Arguments.Count; }


        public ClassicArgument(params decimal[] arguments) => this.Arguments = arguments.ToList();
        

        public decimal GetArgument(int argumentNumber)
        {
            if(this.GetArgumentCount < argumentNumber)
            {
                throw new ArgumentOutOfRangeException(nameof(argumentNumber));
            }

            return this.Arguments[argumentNumber - 1];
        }
    }
}
