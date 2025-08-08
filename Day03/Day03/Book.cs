using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class Book
    {
        #region Property
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        #endregion

        #region Constructor
        public Book(string title ,string author ,string ISBN)
        {
            Title = title;
            Author = author;
            this.ISBN = ISBN;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"Title : {Title} , Author : {Author} , ISBN --> {ISBN}";
        }
        #endregion
    }
}
