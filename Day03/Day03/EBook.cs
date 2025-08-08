using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class EBook : Book
    {
        #region Property
        public int FileSize { get; set; }
        #endregion

        #region Constructor
        public EBook(int FileSize, string title, string author, string ISBN) : base(title , author ,ISBN)
        {
            this.FileSize = FileSize;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{base.ToString()} , File Size = {FileSize}";
        }
        #endregion
    }
}
