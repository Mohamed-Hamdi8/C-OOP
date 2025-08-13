using Day04.Overriding;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Q.1
            //int a = 5;
            //int b = 10;
            //int c = 20;
            //double x = 2.2;
            //double y = 3.2;
            //Console.WriteLine($"a + b = {Calculator.Add(a, b)}");
            //Console.WriteLine($"a + b + c = {Calculator.Add(a, b, c)}");
            //Console.WriteLine($"x + y = {Calculator.Add(x, y)}");
            #endregion

            #region Q.2
            //Rectangle rectangle01 = new Rectangle();
            //Rectangle rectangle02 = new Rectangle(10,15);
            //Rectangle rectangle03 = new Rectangle(20);
            #endregion

            #region Q.3
            //ComplexNumber C1 = new ComplexNumber(4,5);
            //ComplexNumber C2 = new ComplexNumber(7,8);
            //ComplexNumber C3;

            //Console.WriteLine($"C1 = {C1} \nC2 = {C2}");
            //C3 = C1 + C2;
            //Console.WriteLine($"C1 + C2 = {C3}");
            //C3 = C1 - C2;
            //Console.WriteLine($"C1 - C2 = {C3}");
            #endregion

            #region Q.4
            //Employee employee = new Manager();
            //employee.Work();
            #endregion

            #region Q.5
            //BaseClass baseClass = new DerivedClass2();
            //baseClass.DisplayMessage();

            #region  Then explain the difference between using override and new (using binding behavior)

            /// By New
            /// static Binding [Early Binding]
            /// Compiler Will Bind Function Call Based On Reference not Object
            /// at Compilation Time.

            ///By Override
            /// Dynamic Binding [Late Binding]
            /// CLR Will Bind Function Call Based On Object not Reference
            /// at Runtime. 

            #endregion

            #endregion

            #endregion

            #region Part02

            #region Q.1
            //Maked
            #endregion

            #region Q.2
            //Maked
            #endregion

            #region Q.3
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());
            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());
            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());
            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());
            #endregion

            #region Q.4
            //Duration D1 = new Duration(1, 59, 20);
            //Duration D2 = new Duration(1, 59, 20);
            //Duration D3;

            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3 = --D2;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);


            //if(D1 > D2)
            //    Console.WriteLine("D1 > D2");
            //else if ( D1 < D2)
            //    Console.WriteLine("D1 < D2");
            //else
            //    Console.WriteLine("D1 == D2");


            //if(D1 >= D2)
            //    Console.WriteLine("Enterd");

            //if(D1)
            //    Console.WriteLine("Enterd");


            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj.Hour);
            //Console.WriteLine(Obj.Minute);
            //Console.WriteLine(Obj.Second);

            #endregion

            #endregion
        }
    }
}
