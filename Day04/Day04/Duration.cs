using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors
        public Duration()
        {
            
        }
        public Duration(int hours , int minutes , int seconds)
        {
            Hours = hours ;
            Minutes = minutes ;
            Seconds = seconds ;
        }
        public Duration(int seconds)
        {
            Hours =seconds / (60*60) ;
            seconds %= 3600;
            Minutes = seconds / (60) ;
            seconds %= 60;
            Seconds = seconds ;
        }
        #endregion

        #region Methods
        public override bool Equals(object obj)
        {
            if (obj is Duration duration)
            {
                return this.Hours == duration.Hours &&
                       this.Minutes == duration.Minutes &&
                       this.Seconds == duration.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override string ToString()
        {
            return $"Hours: {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
        }
        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static Duration operator +(Duration left ,  Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            };
        }
        public static Duration operator -(Duration left ,  Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) - (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) - (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) - (right?.Seconds ?? 0)
            };
        }

        public static Duration operator +(Duration duration , int second)
        {
            return new Duration()
            {
                Hours = (duration?.Hours ?? 0) + (second / 3600),
                Minutes = (duration?.Minutes ?? 0) + ((second % 3600) / 60),
                Seconds = (duration?.Seconds ?? 0) + ((second % 3600)%60)
            };
        }
        public static Duration operator +(int second , Duration duration)
        {
            return new Duration()
            {
                Hours = (duration?.Hours ?? 0) + (second / 3600),
                Minutes = (duration?.Minutes ?? 0) + ((second % 3600) / 60),
                Seconds = (duration?.Seconds ?? 0) + ((second % 3600)%60)
            };
        }

        public static Duration operator ++(Duration duration)
        {
            int hours, minutes, seconds;
            if (duration.Minutes==59)
            {
                hours = (duration?.Hours ?? 0) + 1;
                minutes = 0;
                seconds = (duration?.Seconds ?? 0);
            }
            else
            {
                hours = duration?.Hours ?? 0;
                minutes = (duration?.Minutes ?? 0) + 1;
                seconds = (duration?.Seconds ?? 0);
            }
                return new Duration()
                {
                    Hours = hours,
                    Minutes = minutes,
                    Seconds = seconds
                };

        }
        public static Duration operator --(Duration duration)
        {
                return new Duration()
                {
                    Hours = duration?.Hours ?? 0,
                    Minutes = (duration?.Minutes ?? 0) - 1,
                    Seconds = (duration?.Seconds ?? 0)
                };

        }


        public static bool operator >(Duration left, Duration right)
        {
            if (left is not null && right is not null)
            {
                if (left.Hours == right.Hours)
                {
                    if (left.Minutes == right.Minutes)
                        return left.Seconds > right.Seconds;
                    else
                        return left.Minutes > right.Minutes;

                }
                else
                    return left.Hours > right.Hours;
            }
            else
                return false;
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left is not null && right is not null)
            {
                if (left.Hours == right.Hours)
                {
                    if (left.Minutes == right.Minutes)
                        return left.Seconds < right.Seconds;
                    else
                        return left.Minutes < right.Minutes;

                }
                else
                    return left.Hours < right.Hours;
            }
            else
                return false;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left is not null && right is not null)
            {
                if (left.Hours == right.Hours)
                {
                    if (left.Minutes == right.Minutes)
                        if (left.Seconds == right.Seconds)
                            return true;
                        else
                            return (left.Seconds > right.Seconds);
                    else
                        return left.Minutes > right.Minutes;

                }
                else
                    return left.Hours > right.Hours;
            }
            else
                return false;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left is not null && right is not null)
            {
                if (left.Hours == right.Hours)
                {
                    if (left.Minutes == right.Minutes)
                        if (left.Seconds == right.Seconds)
                            return true;
                        else
                            return (left.Seconds < right.Seconds);
                    else
                        return left.Minutes < right.Minutes;

                }
                else
                    return left.Hours < right.Hours;
            }
            else
                return false;
        }

        public static bool operator true(Duration duration)
        {
            return duration.TotalSeconds() > 0;
        }
        public static bool operator false(Duration duration)
        {
            return duration.TotalSeconds() <= 0;
        }


        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(1, 1, 1, duration?.Hours??0, duration?.Minutes??0, duration?.Seconds ?? 0);
        }


        #endregion
    }
}
