using PolymorphismPractice.Calculator.Argument;
using PolymorphismPractice.Calculator.Calculator;
using PolymorphismPractice.Calculator.MathFunction;
using PolymorphismPractice.Inheritance;
using PolymorphismPractice.Interface;

namespace PolymorphismPractice 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Inheritance-Method Overriding

            Employee employee;

            employee = new Employee() { Name = "Employee 1" };
            Console.WriteLine(employee.CalculateSalary());  //4.000$

            employee = new Worker() { Name = "Worker 1", YearsOfExperience = 3 };
            Console.WriteLine(employee.CalculateSalary());  //7.000$

            employee = new Manager() { Name = "Manager 1", YearsOfExperience = 8 };
            Console.WriteLine(employee.CalculateSalary()); //17.000$

            employee = new Director() { Name = "Director 1", YearsOfExperience = 10 };
            Console.WriteLine(employee.CalculateSalary());  //29.000$


            //Interface
            IShape shape;

            shape = new Triangle() { FirstEdge = 5, SecondEdge = 10, ThirdEdge = 6 };
            Console.WriteLine(shape.CalculatePerimeter());

            shape = new Rectangle() { LongEdge = 10, ShortEdge = 5 };
            Console.WriteLine(shape.CalculatePerimeter());

            shape = new Square() { Edge = 20 };
            Console.WriteLine(shape.CalculatePerimeter());


            //---------------------------------------------------------------------------------------------

            //Advanced
            //Temel Düzeyde Bir Hesap Makinesi Tasarlayınız.  
            //Bu Makine Üzerine Yeni Matematiksel Fonksiyon Modülleri Eklenebilmelidir.
            //Her Fonksiyon, Farklı Parametre Sayısı İle Çalışabilir.

            ICalculator calculator = new ClassicCalculator();

            IMathFunction sumFunction = new SumFunction();
            IMathFunction multiplicationFunction = new MultiplicationFunction();
            IMathFunction divisionFunction = new DivisionFunction();

            calculator.AddMathFunction(sumFunction);
            calculator.AddMathFunction(multiplicationFunction);
            calculator.AddMathFunction(divisionFunction);

            calculator.ListCalculatorFunctions();

            IArgument sumArgs = new ClassicArgument(5, 10);
            IArgument sumArgs2 = new ClassicArgument(5, 10, 30);
            IArgument sumArgs3 = new ClassicArgument(5, 10, 30,100,1000);

            IArgument multiplicationArgs = new ClassicArgument(2,3);
            IArgument multiplicationArgs2 = new ClassicArgument(2, 3, 5);
            IArgument multiplicationArgs3 = new ClassicArgument(2, 3, 5, 10);

            IArgument divisionArgs = new ClassicArgument(50,5);
            IArgument divisionArgs2 = new ClassicArgument(250, 10);
            IArgument divisionArgs3 = new ClassicArgument(10, 500);

            Console.WriteLine(calculator.Calculate(nameof(SumFunction), sumArgs));   //15
            Console.WriteLine(calculator.Calculate(nameof(SumFunction), sumArgs2));  //45
            Console.WriteLine(calculator.Calculate(nameof(SumFunction), sumArgs3));  //1145

            Console.WriteLine(calculator.Calculate(nameof(MultiplicationFunction), multiplicationArgs));  //6
            Console.WriteLine(calculator.Calculate(nameof(MultiplicationFunction), multiplicationArgs2)); //30
            Console.WriteLine(calculator.Calculate(nameof(MultiplicationFunction), multiplicationArgs3)); //300

            Console.WriteLine(calculator.Calculate(nameof(DivisionFunction), divisionArgs));   //10
            Console.WriteLine(calculator.Calculate(nameof(DivisionFunction), divisionArgs2));  //25
            Console.WriteLine(calculator.Calculate(nameof(DivisionFunction), divisionArgs3));  //Exception


            Console.ReadLine();
        }
    }
}