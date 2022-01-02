using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.Argument
{
    public interface IArgument
    {
        public int GetArgumentCount { get; }
        decimal GetArgument(int argumentNumber);
    }
}
