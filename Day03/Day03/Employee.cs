using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityPrivileges SecurityPrivileges { get; set; }
        public decimal Salary { get; set; }
        public HiringDate? HireDate { get; set; }
        public Gender Gender { get; set; }
        #endregion

        #region Constructors
        public Employee(int id, string name, SecurityPrivileges securityPrivileges, decimal salary, HiringDate hiringDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityPrivileges = securityPrivileges;
            Salary = salary;
            HireDate = hiringDate;
            Gender = gender;
        }
        public Employee() 
        {
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , SecurityPrivileges: {SecurityPrivileges} , Salary: {string.Format("{0:C}",Salary)} , HireDate: {HireDate} , Gender: {Gender}";
        }
        #endregion
    }
}
