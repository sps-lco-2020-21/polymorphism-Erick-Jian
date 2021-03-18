using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualNewOverride
{
    public class Student: Person        // Q: WDM ??? WHY ???
    {
        public Student(string First, string Last, string email, DateTime DoB) : base(First, Last, email, DoB)
        {        }

        public Student(string first, string last, DateTime DoB) : base(first, last, DoB)
        {        }

        public int GetDateOfBirth
        {   get { return _DoB; }    }

        public int GetAge
        {   get { return _Age; } }      // Years all round down / truncated

        public override int DateofBirth()
        {
            return _DoB;
        }

        public override bool ThisisAnAge(int age)
        {
            return (age >= 0);
        }

        public override bool IsOverAge()
        {
            return Convert.ToInt32(_Age) >= 18;
        }

        public override string ChineseZodiac()
        {
            int Year = _DoB;
            int ZodiacCounter = Year % 12;  // 12 years

            // 1900, 2020: Year of Mouse; 1970: Year of Dog     12 | 1968 (Monkey 164)

            生肖 YourCHZodiac = (生肖)ZodiacCounter;
            return Convert.ToString(YourCHZodiac);
        }

        public override string GenerateScrnName()
        {
            string dateofbirth = _DoB.ToString();
            string DOBSeries = dateofbirth.Substring(6, 3);
            // DD/MM/YY HH/MM/SS

            string timenow = Convert.ToString(DateTime.Now);
            string NowTimeSeries = timenow.Substring(11,2) + timenow.Substring(14, 2) + timenow.Substring(17,2);

            string FirstChar = _1stname.Substring(0,2);
            string SurChar = _Surname;      // could just use _Surname

            return (FirstChar + SurChar + DOBSeries + NowTimeSeries);
        }
    }

    public class Teachers: Person
    {
        // will be similar to students but different O/P structures
    }
}
