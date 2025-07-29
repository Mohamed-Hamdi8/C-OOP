namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] person = new Person[3];
            //person[0] = new Person("Mohamed", 20);
            //person[1] = new Person("Hamdi", 52);
            //person[2] = new Person("Sobhi", 78);
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}
            #endregion

            #region 2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point p01 = new Point();
            //Console.Write("Enter X1 : ");
            //p01.X = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y1 : ");
            //p01.Y = double.Parse(Console.ReadLine());
            //Point p02 = new Point();
            //Console.Write("Enter X2 : ");
            //p02.X = double.Parse(Console.ReadLine());
            //Console.Write("Enter Y2 : ");
            //p02.Y = double.Parse(Console.ReadLine());

            //double Distance = Math.Sqrt(Math.Pow((p02.X - p01.X), 2) + Math.Pow((p02.Y - p01.Y), 2));
            //Console.WriteLine($"The distance between the two points is : {Distance}");
            #endregion

            #region 3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] person = new Person[3];
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Enter Details Person {i + 1}");
            //    Console.Write($"Name : ");
            //    string name = Console.ReadLine();
            //    int age;
            //    while (true)
            //    {
            //        Console.Write("Age: ");
            //        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            //            break;
            //        Console.WriteLine("Invalid age. Please enter a non-negative integer.");
            //    }

            //    person[i] = new Person { Name = name, Age = age };
            //}

            //Person oldest = person[0];
            //foreach (Person p in person)
            //{
            //    if (p.Age > oldest.Age)
            //    {
            //        oldest = p;
            //    }
            //}
            //Console.WriteLine(oldest);
            #endregion

            #region Create a struct named Rectangle that represents a rectangle with the following fields:
            //Rectangle rect = new Rectangle();

            //rect.Width = 5.5;
            //rect.Height = 3.2;

            //rect.Width = -2;
            //rect.Height = -4;

            //rect.DisplayInfo();
            #endregion
        }
    }

}
