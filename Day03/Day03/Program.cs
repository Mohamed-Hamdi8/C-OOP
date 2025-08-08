namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Q.1
            //Maked 
            #endregion

            #region Q.2
            //Maked
            #endregion

            #region Q.3
            //Employee[] employees = new Employee[3];
            //bool Parsed;
            //int Id;
            //string Name;
            //decimal Salary;
            //int day;
            //int month;
            //int year;
            //Gender Gender;
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine($"Enter Employee {i+1} Data : ");
            //    do
            //    {
            //        Console.Write("Id : ");
            //        Parsed = int.TryParse(Console.ReadLine(), out Id);
            //    } while (!Parsed);
            //    do
            //    {
            //    Console.Write("Name : ");
            //        Name = Console.ReadLine(); 
            //    }while (Name is null);
            //    do
            //    {
            //        Console.Write("Salary : ");
            //        Parsed = decimal.TryParse(Console.ReadLine(), out  Salary);
            //    } while (!Parsed);
            //    do
            //    {
            //        Console.Write("Day :  ");
            //        Parsed = int.TryParse(Console.ReadLine(), out day);
            //    } while (!Parsed || day <= 0 || day > 31);
            //    do
            //    {
            //        Console.Write("Month :  ");
            //        Parsed = int.TryParse(Console.ReadLine(), out month);
            //    } while (!Parsed || month <= 0 || month > 12);
            //    do
            //    {
            //        Console.Write("Year :  ");
            //        Parsed = int.TryParse(Console.ReadLine(), out  year);
            //    } while (!Parsed);
            //    do
            //    {
            //        Console.Write("Enter Gender (M/F) : ");
            //        Parsed = Enum.TryParse(Console.ReadLine(), true, out Gender);
            //    } while (!Parsed);
            //    if(i==0)
            //        employees[i] = new Employee(Id, Name, SecurityPrivileges.DBA, Salary, new HiringDate(day, month, year), Gender);
            //    else if (i==1)
            //        employees[i] = new Employee(Id, Name, SecurityPrivileges.Guest, Salary, new HiringDate(day, month, year), Gender);
            //    else if (i==2)
            //        employees[i] = new Employee(Id, Name, (SecurityPrivileges)15, Salary, new HiringDate(day, month, year), Gender);


            //}
            //foreach (Employee employee in employees)
            //    Console.WriteLine(employee);
            #endregion

            #region Q.4
            //Employee[] emp = new Employee[3];
            //emp[0] = new Employee(1, "Ali", SecurityPrivileges.Developer, 10000, new HiringDate(1, 2, 2020), Gender.m);
            //emp[1] = new Employee(2, "Sara", SecurityPrivileges.Guest, 5000, new HiringDate(5, 4, 2021),Gender.f);
            //emp[2] = new Employee(3, "Omar", SecurityPrivileges.Secretary, 15000, new HiringDate(10, 1, 2019),Gender.m );

            //Array.Sort(emp, (e1, e2) =>
            //{
            //    int d1 = e1.HireDate.ToNumber(); // No boxing
            //    int d2 = e2.HireDate.ToNumber(); // No boxing
            //    return d1.CompareTo(d2); 
            //});
            //foreach (Employee employee in emp)
            //    Console.WriteLine(employee);
            #endregion

            #region Q.5
            //EBook ebook = new EBook(500,"C# Basics", "Alice Smith", "978-1-23456-789-0");
            //PrintedBook printed = new PrintedBook(350,"Learn OOP", "John Doe", "978-0-98765-432-1");

            //Book[] library = new Book[] { ebook, printed };

            //foreach (Book book in library)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #endregion
        }
    }
}
