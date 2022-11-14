using System;
namespace myEnum
{
    class Program
    {
        enum Months
        {
            January,
            February,
            March = 7,
            April,
            May
            
        }
        static void Main(string[] args)
        {
        //    Months myMonth = Months.January;
        //    Console.WriteLine(myMonth);
        //    int mymonth = (int) Months.April;
        //    Console.WriteLine(mymonth);
            Months myMonth = Months.January;
            switch (myMonth)
            {
                case Months.May:
                Console.WriteLine("May");
                break;

                case Months.January:
                Console.WriteLine("January");
                break;

                case Months.April:
                Console.WriteLine("April");
                break;
            }

        }
    }
}