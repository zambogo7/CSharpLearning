using System;
using System.IO;
namespace Myfile
{
    class Program 
    {
        static void Main()
        {
            string writeText = "Hello World";
            File.WriteAllText("filename.txt", writeText );

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);

        }
    }
}