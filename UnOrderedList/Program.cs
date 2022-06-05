using System;
namespace UnOrderedList
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListData list = new LinkedListData();
            list.Add("prasanna");
            list.Add("arjun");
            list.Add("malli");
            //list.DisPlay();
            int a = list.Search("arjun");
            Console.WriteLine("index position of element is: " + a);
            list.InsertAtPerticularPosition(a + 1, "lakshmi");
           // list.DisPlay();
            list.RemoveFirstNode("prasanna");
           // list.RemoveLastNode("malli");
            list.DisPlay();
        }
    }
}

