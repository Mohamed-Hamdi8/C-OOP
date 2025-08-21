using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bulit_In_Interfaces
{
    internal class Employee :ICloneable ,IComparable<Employee>
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
        #endregion

        #region Constructors
        public Employee()
        {
            
        }

        //Copy Constructor : is a special Constructor Used To Make a Deep Copy For The ReferenceType Object
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
            Department = emp.Department;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }
        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
                Department = this.Department
                //Department = (Department)this.Department.Clone() //If You Need Make Deep Copy For Department
            };
        }

        public int CompareTo(Employee? other)
        {
            return this.Salary.CompareTo(other?.Salary);
           // return (this.Salary == other?.Salary)? 0 : this.Salary > other?.Salary? 1:-1 ;
        }
        #endregion
    }
}
