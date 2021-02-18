using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if (startDate != null && dayCount > -1)
            {
              
                if (weekEnds != null && weekEnds.Length > 0)
                {

                    while (dayCount > 0)
                    {
                        if( isWeekend(startDate, weekEnds) == false)
                        {
                            startDate = startDate.AddDays(1);
                            dayCount--;
                        } else
                        {
                            startDate = startDate.AddDays(1);
                        }

                    }
                } else
                {
                    startDate = startDate.AddDays(dayCount);
                }

            }
            startDate = startDate.AddDays(-1);

            return startDate;
        }

        public bool isWeekend(DateTime startDate, WeekEnd[] weekEnds)
        {
            foreach (WeekEnd item in weekEnds)
            {
            
                if (item.StartDate <= startDate && startDate <= item.EndDate)
                {
                    return true;
                }

            }

            return false;
        }

    }
}
