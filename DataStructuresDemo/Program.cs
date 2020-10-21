using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Elements are:");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertData(2, 40);
            list.Display();
            list.DeleteDataAtPosition(3);
            list.Display();
            Console.WriteLine();
        }
    }
}
