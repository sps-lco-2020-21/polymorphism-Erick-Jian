using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace VirtualNewOverride
{
    /// <summary>
    /// Interface vs Baseclass:
    ///     Allow MULTIPLE Interface but ONLY ONE Baseclass
    /// 
    /// </summary>

    class Polymorphism
    {
        static void Main(string[] args)
        {
            DateTime Birthday = new DateTime (2004, 3, 16);
            Student Me = new Student("Stavros", "Fakiolas", "fakiolass@stpaulsschool.org.uk", Birthday);
            Person CloneMe = Me;

            Console.WriteLine(Me.ChineseZodiac());  // O/P "申" -- (Year of) Monkey

            decimal RawYear = (int)Me.GetAge / 365;
            int ProcessedRawYear = (int)Math.Truncate(RawYear);
            Debug.Assert( ProcessedRawYear == 17);


            while (Console.ReadKey().Key != ConsoleKey.Escape)
                Console.WriteLine("press [Esc] to exit the program");

            // please see UnitTest file for more
        }
    }

    class Program
    {
        // based on the example here: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords 
        static void Main(string[] args)
        {
            #region 1
            // Step 1 create the instances of the objects 
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();

            // this is the one that's going to mess with your heads. 
            BaseClass bcdc = new DerivedClass();
            // DerivedClass dcbc = new BaseClass();     // can't do that

            Console.WriteLine("bc 1/2");
            bc.Method1();
            bc.Method2();

            Console.WriteLine("\ndc 1/2");
            dc.Method1();
            dc.Method2();

            Console.WriteLine("\nbcdc 1/2");
            bcdc.Method1();
            #endregion

            #region 3 predict the output 
            //// #3            
            bcdc.Method2();

            #endregion

            #region 7 lists

            // step 7 - putting them in a list 

            List<BaseClass> lb = new List<BaseClass> { bc, dc, bcdc };
            // List<DerivedClass> ld = new List<DerivedClass> { bc, dc, bcdc};      // (line 24) can't do it
            List<AbstractBaseClass> Ib = new List<AbstractBaseClass> { bc, dc, bcdc };

            #endregion

            #region 8 
            // step 8 method 3 - will work with ld, but not with lb
            #endregion

            #region 9 abstract
            // step 9 note we've not even talked about abstract ... 
            #endregion

            Console.ReadKey();
        }

        abstract class AbstractBaseClass // can't be instantiates (can't create instance -- cac't call it)
                                         // Abstract can't be 
        {
            protected int _abstractMemberItem;
            // protected: ONLY class and DERIVED class can see it
            // internal protected: can extend on it (giving module)

            /// CUSTOMIZED Access Modifier: 
            public abstract void MustImplementedThis(); // used in the DerivedClass
                                                        // abstract class can't be virtual

            public void MethodA()
            {
                Console.WriteLine("Abstract Class - MethodA");
            }
        }

        /// <summary>
        /// A base class which implements 2 functions 
        /// </summary>
        class BaseClass : AbstractBaseClass
        {
            #region 5 virtual 
            // step 5 - what effect does the virtual keyword have? 
            // the importance of new vs override in the derived class. 
            public virtual void Method1()
            {
                Console.WriteLine("Base - Method1");
            }
            #endregion

            #region 2 method 2 - a straight method (not virtual - see later, #5) 
            // step 2 - a straight function - base.method2 is always coming here 
            public void Method2()
            {
                Console.WriteLine("Base - Method2");
            }

            public override void MustImplementedThis()  // need to implement MustImplementedThis() from Abstract
            {
                throw new NotImplementedException();
            }
            #endregion

        }

        /// <summary>
        /// a derived class, which inherits from the base class 
        /// </summary>
        class DerivedClass : BaseClass
        {
            #region 6 override 
            // // #6
            public override void Method1()
            {
                Console.WriteLine("Derived - Method1");
            }
            #endregion

            #region 4 new 
            // #4 new 
            #endregion

            public new void Method2()
            {
                Console.WriteLine("Derived - Method2");
            }

            public void Method3()
            {
                Console.WriteLine("Derived - Method3");

            }
        }
    }
}
