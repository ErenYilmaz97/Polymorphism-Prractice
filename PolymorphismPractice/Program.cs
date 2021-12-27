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

            Console.ReadLine();
        }
    }
}