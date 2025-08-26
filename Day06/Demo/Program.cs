using Demo.Abstraction;
using Demo.Partial;
using Demo.Sealed;
using Demo.Static;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction [Abstract Class ,Abstract Method ,Abstract Property]
            //Square square = new Square(10);
            //Console.WriteLine($"Square Area = {square.CalcArea()}");
            //Console.WriteLine($"Square Perimeter = {square.perimeter}");
            //Draw2D(square);
            #endregion

            #region Static
            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CalcCircleArea(10));
            //Console.WriteLine(Utility.CalcCircleArea(10)); 
            #endregion

            #region Sealed
            ///You can create object from sealed class
            //GrandChild grandChild = new GrandChild();
            //grandChild.Salary = 11000;
            //Console.WriteLine(grandChild.Salary);
            //grandChild.Print();

            //Parent parent = new GrandChild();
            //parent.Print(); //I am Child ==> Because Child Make This Method seald So The Last override in Child
            #endregion

            #region Partial
            //Employee employee = new Employee()
            //{
            //    Id = 1001,
            //    Name = "Mohamed",
            //    Age = 20,
            //    Address ="Menofia"
            //};

            #endregion

            #region Types Of Class
            ///1.Concrete Class
            ///2.Static   Class
            ///3.Abstract Class
            ///4.Sealed   Class
            ///5.Partial  Class 
            #endregion

        }
        #region Methods
        public static void Draw2D(IDraw2D Shape)
        {
            Shape.Draw();
        } 
        #endregion
    }
}
