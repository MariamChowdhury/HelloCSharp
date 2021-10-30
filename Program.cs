using System;

namespace HelloWorld01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            //checking a comment 
            try
            {
                var num = 1211124;
                byte num2 = Convert.ToByte(num);
                System.Console.WriteLine(num2);
            }
            catch (Exception)
            {
                System.Console.WriteLine("Error !!!");
            }
        }
    }
}
