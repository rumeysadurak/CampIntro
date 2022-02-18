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

            //Dictionary
            MyDictionary<int, string> cities =new MyDictionary<int, string>();
            cities.Add(16, "Bursa");
            cities.Add(34, "İstanbul");
            cities.Add(10, "Balıkesir");
            cities.Add(7, "Ankara");

            Console.WriteLine("All pairs in MyDictionary:");
            cities.ShowAllKeyValuePairs();







            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("MyList:");
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
