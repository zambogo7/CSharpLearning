// This is a single comment
/*This is a multiple comment 
*/

using System;
using System.Linq;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Console.WriteLine("I'm Learning C#");
            Console.WriteLine("It is Awesome");

            // Variable sring
            string student = "Zeddy";
            Console.WriteLine(student);

            //variable number
            int num = 15;
            Console.WriteLine(num);
            // other variables used in c#
/*
            double  myDouble = 5.44;
            // char myChar = "Z";
            bool mybool = true;

            // constant

            const int myNum = 15;

            //concatenation
*/
            string firstname = "Zedekiah";
            string secondname  = "Ambogo";
            string fullname = firstname + secondname;

            Console.WriteLine(fullname);

            int x = 5;
            int y = 6;
            int z = x + y;
            Console.WriteLine(z);

            //Type casting

            /*  implicit smallt to large
            */
            int  mynummn = 15;
            double mynum = mynummn;
            Console.WriteLine(mynum);

            // Explicit large to small

            double  l = 15.9;
            int ltos = (int) l;
            Console.WriteLine(ltos);

            //user input
/*
            Console.WriteLine("Enter the park");
            string park = Console.ReadLine();
            Console.WriteLine(park);
*/

            //user input for numbers
/*
            Console.WriteLine("Enter the number of parks");
            int parknumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amboseli is park number:" + parknumber);
*/
            //comparison operator
            int u = 5;
            int v = 3;
            Console.WriteLine(u > v);
            //string interpolation

           string first = "Zedekiah";
           string last = "Ambogo";
           string full = $"My full name {first} {last}";
           Console.WriteLine(full);

           string lion = "canis ";
           Console.WriteLine(lion[0]);

           //Boolean
           bool iscsharpfun = true;
           bool isFishtasty = false;

           Console.WriteLine(iscsharpfun);
           Console.WriteLine(isFishtasty);

           //if ... else statement

           int time = 24;
           
           if (time < 11)
           {
            Console.WriteLine("Good Morning");
           }
           else if (time < 16)
           {
            Console.WriteLine("Good Afternoon");
           }
           else 
           {
            Console.WriteLine("Good Evening");
           }

           // Switch

           int day = 4;
           switch (day)
           {
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
            case 7:
            Console.WriteLine("Sunday");
            break;

           }

           //while loop

           int i = 0;
           while (i < 5)
           {
            Console.WriteLine(i);
            i++;
           }

           //do while

           int k = 0;
           do 
           {
            Console.WriteLine(k);
            k++;
        
           }
           while(k<10);
// for loop
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Learning is greate");
            }

            string[] cars = {"volvo", "benz", "nisaan"};
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            for (int m = 0; m < 10; m++)
            {
                if (m == 5)
                {
                    break;
                }
                Console.WriteLine(m);
            }
            for (int n = 0; n < 10; n++)
            {
                if (n == 5)
                {
                    continue;
                }
                Console.WriteLine(n);
            }
            // break and continue
           
           int q = 10;
           while (q < 15)
           {
            Console.WriteLine(q);
            q++;
            if (q == 13)
            {
                break;
            }
           }
           int w = 30;
           while (w < 50)
           {
           
            if (w == 40)
            {
                w++;
                continue;
            }
            Console.WriteLine(w);
            w++;
           }

           //Array
           

           string[] bus ={"Nissan", "BMW", "Benz"};
           int[] mynumbers = {10,20,30,40};
        
           Console.WriteLine(bus[0]);
           string[] vehicle;
           vehicle = new string[]{"car", "bus", "motorcycle"};
           Console.WriteLine(vehicle[0]);

           foreach (string item in bus){
            Console.WriteLine(item);
           }
           Console.WriteLine(mynumbers.Max());

           int[,] thenum = {{1,4,5,6,}, {3,5,6,2,}};
           Console.WriteLine(thenum[1,2]);
           
           Console.WriteLine(thenum[1,2] = 7);
           foreach (int d in thenum){
            Console.WriteLine(d);
           }


        }
    }
}