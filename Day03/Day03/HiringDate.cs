using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class HiringDate
    {
        #region Properties
        private int day;
        public int Day
        {
            get { return day; }
            set { day = value >= 1 && value <= 31 ? value : -1; }
        }


        private int month;
        public int Month
        {
            get { return month; }
            set { month = value >= 1 && value <= 12 ? value : -1; }
        }


        private int year;
        public int Year
        {
            get { return year; }
            set { year = value > 0 ? value : -1; }
        }

        #endregion

        #region Constructors
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        public int ToNumber()
        {
            return Year * 10000 + Month * 100 + Day;
        }
        public override string ToString()
        {
            return $"{Day}:{Month}:{Year}";
        }
        #endregion
    }
}
