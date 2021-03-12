﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualNewOverride
{
    // readonly ≈ semi-constant
    public class Person
    {
        string _1stname, _2ndname, _email;
        protected DateTime _DoB;
        // Timespan: difference between two time

        # region Notes: 
        // constructors can take in a old instance      --    Aliasing
        //      when equate new instance to old one, doesn't simply copy -- BOTH POINT to the data "block", 
        //      ONE updates, TWO refreshes data;
        // priate setter can be only set in the CLASS
        // protected: only class & DERIVED class
        // readonly: only in CONSTRUCTOR


        // Structs & int, string are VALUE types        --      copy
                        // keyword ref make it REF types        copy to edit
        // Objects are REFERENCE types      --      edit
        // ICloneable -- return a copy
        //               via the .Clone method
        # endregion

        public Person(string First, string Last, string email, DateTime DoB)
        {
            _1stname = First;
            _2ndname = Last;
            _email = email;
            _DoB = DoB;
        }

        public Person(string first, string last, DateTime dOb)
        {
            _1stname = first;
            _2ndname = last;
            _DoB = dOb;
        }

        public DateTime DateOfBirth
        {
            get {   return _DoB; }
        }

        public TimeSpan ComputeAge()
        {
            return (DateTime.Now - _DoB);
        }

        public bool ConfirmAge(TimeSpan age)
        {
            return false;
        }

        public bool ThisIsAnAge(int age)
        {
            return (age >= 0);
        }

        public bool IsOverAge(TimeSpan age)
        {
            return Convert.ToInt32(age) >= 18;
        }

        public string Zodiac()
        {
            int Year = _DoB.Year;    // .Year O/P integer
            int ZodiacCounter = Year % 12;

            // 1900, 2020: Year of Mouse; 1970: Year of Dog     12 | 1968 (Monkey 164)

            生肖 YourCHZodiac = (生肖)ZodiacCounter;
            return Convert.ToString(YourCHZodiac);
        }

        public string GenerateScrnName(Person User)
        {
            string DOBSeries = Convert.ToString(_DoB);
            string FirstLetter = Convert.ToString(_1stname);
            // need to adjust the type
            return (Convert.ToString(_2ndname) + Convert.ToString(_1stname) + DOBSeries);
        }
    }

    public enum 生肖  // means Chinese Zodiac
    {
        // 1900, 2020 is the year of rat, so just 0

        申, 酉, 戌, 亥, 子, 丑, 寅, 卯, 辰, 巳, 午, 未
    //  猴  鸡  狗  猪  鼠  牛  虎  兔  龙  蛇  马  羊
    //  monkey       | rat                snake   sheep
    }
}
