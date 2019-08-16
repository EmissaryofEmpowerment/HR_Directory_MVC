using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Directory_MVC.Models
{
    public class RetentionStatistics: Employee
    {
        public Int32 WeeklyHires { get; set; }
        public Int32 YearlyTerminationTo_Date { get; set; }
        public Int32 MonthlyHires { get; }
        public Int32 YearlyHiresTo_Date { get; }
        public Int32 WeeklyTermination { get; }
        public Int32 MonthlyTermination { get; }
        public RetentionStatistics()
        {

        }

        //The parameterized Constructor I intend to keep an accurate and current count of
        //Retention Statistics. So, I need to make sure that Weekly Hires/Terminations 
        //only get calculated once a month and Yearly Hires/Terminations only get calculated
        //once a year...
        public RetentionStatistics(Int32 _WeeklyHires, Int32 _YearlyTerminationTo_Date)
        {
            _WeeklyHires = WeeklyHires;
            _YearlyTerminationTo_Date = YearlyTerminationTo_Date;
            if (this.HireDate.Day >= (DateTime.Today.Day -7))
            {
                WeeklyHires++;
            }
            if (this.HireDate.Month == DateTime.Today.Month)
            {
                MonthlyHires++;
            }
            if (this.HireDate.Year == DateTime.Today.Year)
            {
                YearlyHiresTo_Date++;
            }
            if (this.TerminationDate.Year == DateTime.Today.Year)
            {
                YearlyTerminationTo_Date++;
            }
            if (this.TerminationDate.Month == DateTime.Today.Month)
            {
                MonthlyTermination++;
            }
            if (this.TerminationDate>= DateTime.Today.AddDays(-7))
            {
                WeeklyTermination++;
            }
        }
           }
}
