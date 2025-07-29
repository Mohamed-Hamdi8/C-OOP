using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal struct Person
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
        #endregion
    }
}
