using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class BirdCounter
    {
        public int[]? BirdsPerDay { get; set; }
        public void LastWeek()
        {
            foreach (int day in BirdsPerDay)
            {
                Console.Write(day + ", ");
            }
            Console.WriteLine();
        }
        public int Today()
        {
            return BirdsPerDay[BirdsPerDay.Length - 1];
        }
        public void IncrementTodaysCount()
        {
            BirdsPerDay[BirdsPerDay.Length - 1]++;
        }
        public bool HasDayWithoutBirds()
        {
            return BirdsPerDay.Contains(0);
        }
        public int TotalBirds()
        {
            int total = 0;
            foreach (int day in BirdsPerDay)
            {
                total += day;
            }
            return total;
        }
        public int BusyDays()
        {
            int busyDays = 0;
            foreach (int day in BirdsPerDay)
            {
                if (day >= 5)
                {
                    busyDays++;
                }
            }
            return busyDays;
        }
    }
}