using PolymorphismPractice.Calculator.Argument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.MathFunction
{
    public class DivisionFunction : IMathFunction
    {
        //Sadece 2 parametre ile çalışabilir.
        public decimal Calculate(IArgument arg)
        {
            decimal firstNumber = arg.GetArgument(1);
            decimal secondNumber = arg.GetArgument(2);

            if (firstNumber < secondNumber)
                return 0;

            return firstNumber / secondNumber;
        }


        public string GetName() => nameof(DivisionFunction);
    }
}
