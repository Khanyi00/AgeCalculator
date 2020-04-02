using System;

namespace AgeCalculator
{
    public class Age
    {
        public static int CalculateAge(DateTime dob, DateTime currentDate)

        {
            var age = 0;

            var dobYear = dob.Year;
            var dobMonth = dob.Month;
            var dobDay = dob.Day;

            var currentDateYear = currentDate.Year;
            var currentDateMonth = currentDate.Month;
            var currentDateDay = currentDate.Day;

            for (int year = dobYear; year < currentDateYear; year++)
            {
                if (dobYear < currentDateYear)
                {
                    age++;
                }
            }


            if (currentDateMonth < dobMonth)
            {
                age = age - 1;
            }

            if (dobMonth == currentDateMonth)
            {
                if (dobYear % 4 != 0 && currentDateDay < dobDay)
                {
                    age = age - 1;
                }

                if (dobYear % 4 == 0)
                {
                    if (currentDateMonth == dobMonth)
                    {
                        if (dobDay == 29 && currentDateYear % 4 != 0)
                        {
                            var nextMonthMarch = currentDateMonth + 1;

                            if (currentDateMonth != nextMonthMarch && currentDateDay != 01)
                            {
                                age = age - 1;
                            }
                        }
                    }
                }
            }

            return age;
        }
    }
}
