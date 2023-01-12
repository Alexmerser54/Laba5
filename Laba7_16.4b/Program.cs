using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_16._4b
{

    struct Date
    {
        int day;
        int month;
        int year;


        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day
        {
            get
            {
                return day;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
        }

        public override string ToString()
        {
            return $"{day}.{month}.{year}";
        }

        public static int DaysInMonth(int month)
        {
            if (month == 1 | month == 3 | month == 5 | month == 7 | month == 8 | month == 10 | month == 12)
                return 31;
            else if (month == 4 | month == 6 | month == 9 | month == 11)
                return 30;
            return 28;
        }

    };

    class Program
    {
        static void Main(string[] args)
        {
            Date today;
            Console.WriteLine("Введите дату");
            string[] input = Console.ReadLine().Split('.');

            today = new Date(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]), Convert.ToInt32(input[2]));

            int day;
            int month;
            int year;

            if (today.Day == 1)
            {
                if (today.Month == 1)
                {
                    month = 12;
                    year = today.Year - 1;
                }
                else
                {
                    month = today.Month - 1;
                    year = today.Year;
                }
                day = Date.DaysInMonth(month);
            }
            else
            {
                day = today.Day - 1;
                month = today.Month;
                year = today.Year;
            }

            Date yesterday = new Date(day, month, year);
            Console.WriteLine("Вчерашняя дата: " + yesterday);
        }
    }
}
