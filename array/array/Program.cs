using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            myArray[0] = 50;
            myArray[1] = 100;
            myArray[2] = 150;
            myArray[3] = 200;
            myArray[4] = 250;

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
