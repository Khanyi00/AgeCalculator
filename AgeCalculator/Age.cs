using System;

namespace AgeCalculator
{
    public class Age
    {
        public static int CalculateAge(DateTime dob, DateTime currentDate)

        {

            var dobYear = dob.Year;
            var dobMonth = dob.Month;
            var dobDay = dob.Day;

            var currentDateYear = currentDate.Year;
            var currentDateMonth = currentDate.Month;
            var currentDateDay = currentDate.Day;

            var age = currentDateYear - dobYear;

            if (dobYear % 4 == 0)
            {
                if (currentDateMonth == dobMonth && dobDay == 29 || currentDateMonth <= dobMonth)
                {
                    age = age - 1;
                }//until March 1 upwards
            }
            else
            {
                if (currentDateMonth < dobMonth || currentDateDay < dobDay)
                {
                    age = age - 1;
                }
            }
            return age;
        }
    }
}
