using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationASPNET_Cloud.Models
{
    public class Vacations
    {
        public string EmployeeName { get; set; }
        public string TeamType { get; set; }

        public int Vacation { get; set; }

        public int PublicHolidays { get; set; }

        public int YearlyVacation { get; set; }

        public int YearlyPublicHolidays { get; set; }


        public int[] DayOfVacation { get; set; }
        public int[] DayOfPublicHoliday { get; set; }

        public Vacations() { }

        public Vacations(string employeeName,string teamType,int vacation,int publicHolidays, int yearlyVacation, int yearlyPublicHolidays, int[] dayOfVacation,int[] dayOfPublicHoliday)
        {
            this.EmployeeName = employeeName;
            this.TeamType = teamType;
            this.Vacation = vacation;
            this.PublicHolidays = publicHolidays;
            this.YearlyVacation = yearlyVacation;
            this.YearlyPublicHolidays = yearlyPublicHolidays;
            this.DayOfVacation = dayOfVacation;
            this.DayOfPublicHoliday = dayOfPublicHoliday;

        }


        public static List<Vacations> GetVacationList()
        {
            return new List<Vacations>
            {
                new Vacations("Ironman","NWB",4,5,30,10,(new int[]{ 11,22}),(new int[]{ 3})),
                new Vacations("Superman","NWB",4,5,35,10,(new int[]{6,15}),(new int[]{ 4,29})),
                new Vacations("Batman","NWB",4,5,20,10,(new int[]{ 8,25}),(new int[]{ 23})),
                new Vacations("Shaktiman","NWM",4,5,15,10,(new int[]{ 9,19}),(new int[]{17})),
                new Vacations("Hulk","NWM",4,5,10,10,(new int[]{ 13,27}),(new int[]{ 12})),
                 new Vacations("Wizard","NWM",4,5,28,10,(new int[]{ 13,27}),(new int[]{ 12}))
            };
        }

        
        
    }
}
