using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    public class LinkedList
    {
        internal Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                
            }
            Console.WriteLine("Node is added " + node.data);
        }

        public void Display()
        {            
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (temp!= null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
            Console.WriteLine();

        }

        public void InsertData(int position, int data)
        {
            Console.WriteLine("Linked List after insertion: ");
            int i = 1;
            Node node = new Node(data);
            
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                Node q = null;
                while (i != position)
                {
                    q = temp;
                    temp = temp.next;
                    i++;
                }
                q.next = node;
                node.next = temp;
            }
        }

        public void DeleteDataAtPosition(int position)
        {
            int i = 1;
            Node temp = this.head;
            Node q = null;

            while (i!=position)
            {
                q = temp;
                temp = temp.next;
                i++;
            }
            q.next = temp.next;
        }
    }
}
