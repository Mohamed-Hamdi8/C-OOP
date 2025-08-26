using Day06.First_Project;
using Day06.Second_Project;
using Day06.Third_Project;
namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proj01

            #region 1
            //Maked
            #endregion

            #region 2
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P); 
            #endregion

            #region 3
            //Point3D P1, P2;
            //P1= Point3D.ReadPoint("P1");
            //P2= Point3D.ReadPoint("P2");
            //Console.WriteLine(P1);
            //Console.WriteLine(P2); 
            #endregion

            #region 4
            //Point3D P1 = new Point3D(10, 10, 10);
            //Point3D P2 = new Point3D(10, 10, 10);
            //if (P1 == P2)
            //{
            //    Console.WriteLine("Done");
            //} 
            #endregion

            #region 5
            //Point3D[] points= new Point3D[3];
            //points[0] = new Point3D(13, 9, 2);
            //points[1] = new Point3D(5, 71, 12);
            //points[2] = new Point3D(7, 31, 4);
            //Array.Sort(points);
            //foreach (Point3D item in points)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 6
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(4, 5, 6);

            //Console.WriteLine($"P1.GetHashCode() : {P1.GetHashCode()}");
            //Console.WriteLine($"P2.GetHashCode() : {P2.GetHashCode()}");

            //P2 = (Point3D)P1.Clone();
            //Console.WriteLine("After Clone ");
            //Console.WriteLine($"P1.GetHashCode() : {P1.GetHashCode()}");
            //Console.WriteLine($"P2.GetHashCode() : {P2.GetHashCode()}"); 
            #endregion

            #endregion

            #region Proj02
            //int a = 10;
            //int b = 20;
            //Console.WriteLine($"a + b = {Maths.Add(a, b)}");
            //Console.WriteLine($"a - b = {Maths.Substract(a, b)}");
            //Console.WriteLine($"a * b = {Maths.Multiply(a, b)}");
            //Console.WriteLine($"a / b = {Maths.Divide(a,b)}");
            #endregion

            #region Proj03

            #endregion

            #region Proj04
            //int Choose = Validator.ValidateInt("Enter Your Type [ 1.RegularUser\t 2.PremiumUser\t3.GuestUser ] : ", 1, 3);
            //int price = Validator.ValidateInt("Enter Price : ", 1);
            //int quantity = Validator.ValidateInt("Enter Quantity : ", 0);
            //User user;
            //switch (Choose)
            //{
            //    case 1:
            //        user = new RegularUser();
            //        break;
            //    case 2:
            //        user = new PremiumUser();
            //        break;
            //    case 3:
            //        user = new GuestUser();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type, defaulting to Guest.");
            //        user = new GuestUser();
            //        break;
            //}
            //Discount discount = user.GetDiscount();
            //decimal discountAmount = 0;
            //if (discount != null)
            //{
            //    discountAmount = discount.CalculateDiscount(price, quantity);
            //    Console.WriteLine($"Discount Type: {discount.Name}");
            //    Console.WriteLine($"Discount Amount: ${discountAmount}");
            //    Console.WriteLine($"Price Before Discount = {price * quantity} \nAfter Discount = {(price*quantity) - discountAmount}");
            //}
            //else
            //{
            //    Console.WriteLine("No discount applied.");
            //}

            #endregion
        }
    }
}
