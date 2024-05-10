using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Append(int value)
        {
            if (head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(value);
            }
        }

        public void AddToStart(int value)
        {
            if (head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node current = new Node(value);
                current.next = head;
                head = current;
            }
        }

        public void printAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
            Console.WriteLine(current.value);
        }

        public int Pop()
        {
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            int lastInList = current.next.value;
            current.next = null;
            return lastInList;
        }

        public int Unqueue()
        {
            Node current = head;
            int firstNode = current.value;
            head = current.next;
            return firstNode;
        }

        public bool IsCircular()
        {
            Node current = head;
            Node first = head;
            while (current != null)
            {
                if (current.next == first)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void Sort()
        {
            Node current = head;
            Node nextNode = null;
            int temp;

            if (head == null)
            {
                return;
            }
            while (current != null)
            {
                nextNode = current.next;

                while (nextNode != null)
                {
                    if (current.value > nextNode.value)
                    {
                        temp = current.value;
                        current.value = nextNode.value;
                        nextNode.value = temp;
                    }
                    nextNode = nextNode.next;
                }
                current = current.next;
            }
        }


        public int GetMaxNode()
        {
            Sort();
            Node current = head;
         while (current.next.next != null)
            {
                current = current.next;
            }
         int lastInList = current.next.value;
         return lastInList;
        }

        public int GetMinNode()
        {
            Sort();
            Node current = head;
            int lastInList = current.value;
            return lastInList;
        }




        //public IEnumerable<int> ToList()
        //{
        //    Node current = head;
        //    IEnumerable<int> listcopy = new List<int>();
        //    while (current != null)
        //    {
        //        listcopy = current.v;
        //    }
        //}

    }
}
