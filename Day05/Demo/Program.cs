using Demo.interface_Example01;
using Demo.Interface_Example_02;
using Demo.Interface_Example_03;
using Demo.Bulit_In_Interfaces;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface Example 01
            //IType reference;
            ///Declare for Reference of type 'IType', Containing Garbage Value.
            ///This Reference 'reference' can refer to an object of any "Type Implmenting IType Interface".
            ///CLR Will Allocate 4 UnInitialized Bytes in STACK For This Reference . 
            ///CLR Will Allocta 0 Bytes in Heap .

            //reference = new IType(); ==> INVAILD

            ///reference = new TypeA();
            ///reference.MyProperty = 7;
            ///reference.MyMethod();  //"Cr7 is the best player"
            ///reference.print(); //"Default Implmented Method" 

            ///TypeA typeA = new TypeA();
            ///typeA.MyProperty = 7;
            ///typeA.MyMethod();
            /// typeA.print(); ==> INVAILD
            #endregion

            #region Interface Example 02
            //typeA typeA = new typeA();
            //PrintTenNumbersFromSeries(typeA);

            //typeB typeB = new typeB();
            //PrintTenNumbersFromSeries(typeB);

            //typeC typeC = new typeC();
            //PrintTenNumbersFromSeries(typeC);
            #endregion

            #region Interface Example 03
            //Airplane airplane = new Airplane();
            //airplane.Speed = 720;
            ////airplane.Forword(); --> Which one will be implemented?

            //IMoveable moveable = airplane;
            //IFlyable flyable = airplane;

            //moveable.Forward();
            //flyable.Forward();

            #endregion

            #region Shallow Copy VS Deep Copy [Array Of Value Type]

            #region Shallow Copy
            //int[] Arr01 = [1, 2, 3];
            //int[] Arr02 = [4, 5, 6];

            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");
            //Console.WriteLine();

            //Arr02 = Arr01; Console.WriteLine("After Shallow Copy --> Arr02 = Arr01; ");
            ////This Object [1, 2, 3] Has 2 References [Arr01 , Arr02] (اسمين دلع)
            ////This Object [4, 5, 6] Bacome Unreachable object
            ////Shallow Copy (سطحي)

            //Console.WriteLine();
            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); 
            #endregion

            #region Deep Copy
            //int[] Arr01 = [1, 2, 3];
            //int[] Arr02 = [4, 5, 6];

            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");
            //Console.WriteLine();

            //Arr02 = (int[])Arr01.Clone(); Console.WriteLine("After Deep Copy --> (int[])Arr01.Clone(); ");
            ////Clone Method : Will Generate NEW Object With NEW and Different Identitiy.
            ////             : This Object Will Have The Same State(Data) Of The Caller Object.
            ////Deep Copy

            //Console.WriteLine();
            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);
            #endregion

            #endregion

            #region Shallow Copy VS Deep Copy [Array Of Reference Type]

            #region Shallow Copy
            //string[] Names01 = ["Amr", "Mona"];
            //string[] Names02 = ["Ahmed", "Yassmin"];

            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode() = {Names02.GetHashCode()}");
            //Console.WriteLine();

            //Names02 = Names01; Console.WriteLine("After Shallow Copy --> Names02 = Names01; ");
            ////This Object ["Amr", "Mona"] Has 2 References [Names01 , Names02] (اسمين دلع)
            ////This Object ["Ahmed", "Yassmin"] Bacome Unreachable object
            ////Shallow Copy (سطحي)

            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode() = {Names02.GetHashCode()}");

            //Names02[0] = "Khalid";
            //Console.WriteLine(Names01[0]); 

            #endregion

            #region Deep Copy
            //string[] Names01 = ["Amr", "Mona"];
            //string[] Names02 = ["Ahmed", "Yassmin"];

            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode() = {Names02.GetHashCode()}");
            //Console.WriteLine();

            //Names02 = (string[])Names01.Clone(); Console.WriteLine("After Deep Copy --> (string[])Names01.Clone(); ");
            //////Clone Method : Will Generate NEW Object With NEW and Different Identitiy.
            //////             : This Object Will Have The Same State(Data) Of The Caller Object.
            //////Deep Copy

            //Console.WriteLine();
            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode() = {Names02.GetHashCode()}");

            //Names02[0] = "Khalid";
            //Console.WriteLine(Names01[0]);
            #endregion

            #endregion

            #region Bulit-In Interfaces ICloneable
            //Employee employee01 = new Employee() { Id = 1001, Name = "Ali", Salary = 40_000, Department = new Department() { Code = 1111, Title = "CS" }};
            //Employee employee02 = new Employee() { Id = 1002 , Name = "Ola" , Salary = 30_000,Department = new Department()  { Code = 2222, Title = "HR" }};

            //Console.WriteLine($"employee01.GetHashCode() = {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() = {employee02.GetHashCode()}");

            //employee02 = (Employee)employee01.Clone();
            ///Clone Method : Will Generate NEW Object With NEW and Different Identitiy.
            ///             : This Object Will Have The Same State(Data) Of The Caller Object.
            ///Deep Copy

            ///employee02 = new Employee(employee01);
            ///Deep Copy With Constructor

            //employee02.Department.Title = "WO";

            //Console.WriteLine($"employee01.GetHashCode() = {employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() = {employee02.GetHashCode()}");

            //Console.WriteLine(employee01.Department.Title); //WO 
            #endregion

            #region Bulit-In Interfaces ICompareable , IComparer
           // Employee[] employees =
           // {
           //     new Employee() { Id = 1001, Name = "Ali", Salary = 40_000 },
           //     new Employee() { Id = 1003, Name = "Mahmoud", Salary = 20_000 },
           //     new Employee() { Id = 1002, Name = "Ola", Salary = 30_000 },
           //     new Employee() { Id = 1004, Name = "Rana", Salary = 10_000 },
           // };

           //// Array.Sort(employees);
           // Array.Sort(employees,new EmployeeComparer());

           // foreach (Employee emp in employees)
           //     Console.WriteLine(emp);


            #endregion

        }
        #region Methods
        public static void PrintTenNumbersFromSeries(ISeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.GoNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        #endregion
    }
}
