using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(0,"Fatih");
            students.Add(1, "Nisa");
            students.Add(2, "Melek");
            students.Add(3, "Raziye");
            students.Add(4, "Mustafa");
            Console.WriteLine(students.Count);

            students.ListItems();
        }
    }
}
