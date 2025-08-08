using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class PrintedBook : Book
    {
        #region Property
        public int PageCount { get; set; }
        #endregion

        #region Constructor
        public PrintedBook(int PageCount, string title, string author, string ISBN) : base(title, author, ISBN)
        {
            this.PageCount = PageCount;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{base.ToString()} , PageCount = {PageCount}";
        }
        #endregion
    }
}
