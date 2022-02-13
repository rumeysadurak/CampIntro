using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        //ctrl+k ctrl+c ->>comment
        //ctrl+k ctrl+u ->>uncomment

        static void Main(string[] args)
        {
            //string[] array = new string[] {"Selvi","Sevil","Veli","Engin" };
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //Console.WriteLine("----------------------\n");

            //Generic yapı <>
            List<string> myList = new List<string> { "Ayşe"};
            myList.Add("Selvi");
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            myList.Add("Kelebek");
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList[0]);

            Console.WriteLine("----------------------\n");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
