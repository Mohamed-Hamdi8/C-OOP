namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1
            ////Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            ////or
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q.2
            //Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Enter Season (Spring, Summer, Autumn, Winter) : ");
            //Enum.TryParse<Season>(Console.ReadLine(), true, out Season result);
            //switch (result)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("march to may ");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("june to august ");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September to November ");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Season");
            //        break;
            //}

            //MAKE PROTICTIVE CODE

            //Console.Write("Enter Season (Spring, Summer, Autumn, Winter) : ");
            //string season = Console.ReadLine().ToLower();
            //bool flag;
            //if (season == "spring" || season == "summer" || season == "autumn" || season == "winter")
            //{
            //    flag = false;
            //}
            //else
            //{
            //    flag = true;
            //}
            //while (flag)
            //{
            //    Console.WriteLine("Invalid Season");
            //    Console.Write("Enter Season (Spring, Summer, Autumn, Winter) : ");
            //    season = Console.ReadLine().ToLower();
            //    if (season == "spring" || season == "summer" || season == "autumn" || season == "winter")
            //    {
            //        flag = false;
            //    }
            //    else
            //    {
            //        flag = true;
            //    }
            //    while (flag)
            //    {
            //        Console.WriteLine("Invalid Season");
            //        Console.Write("Enter Season (Spring, Summer, Autumn, Winter) : ");
            //        season = Console.ReadLine().ToLower();
            //        if (season == "spring" || season == "summer" || season == "autumn" || season == "winter")
            //        {
            //            flag = false;
            //        }
            //        else
            //        {
            //            flag = true;
            //        }
            //    }
            //    Enum.TryParse<Season>(season, true, out Season result);
            //    switch (result)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("march to may ");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("june to august ");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November ");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Season");
            //            break;
            //    }
            //}
            #endregion

            #region Q.3
            //employee emp = new employee();
            //emp.Permission |= Permission.Read;
            //emp.Permission |= Permission.Write;
            //emp.Permission |= Permission.Delete;
            //emp.Permission |= Permission.Execute;
            //Console.WriteLine(emp.Permission);
            //if ((emp.Permission & Permission.Read) == Permission.Read)
            //{
            //    emp.Permission ^= Permission.Read; //if exist remove it
            //}
            //else
            //{
            //    emp.Permission ^= Permission.Read; //if not exist add it
            //}
            //Console.WriteLine(emp.Permission);
            #endregion

            #region Q.4
            //Console.Write("Enter Color To Know If Primary OR Not : ");
            //string input = Console.ReadLine();
            //Enum.TryParse<color>(input, true, out color result);

            //switch (result)
            //{
            //    case color.Red:
            //    case color.Green:
            //    case color.Blue:
            //        Console.WriteLine("Primary Color");
            //        break;
            //    default:
            //        Console.WriteLine("Not Primary Color");
            //        break;
            //}
            #endregion

        }
    }
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public enum Season
    {
        Spring = 1,
        Summer,
        Autumn,
        Winter
    }
    class employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Permission Permission { get; set; }
    }
    [Flags]
    public enum Permission
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum color
    {
        Red = 1,
        Green,
        Blue
    }
}
