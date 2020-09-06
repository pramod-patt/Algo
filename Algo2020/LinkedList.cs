using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algo2020
{
    // Find reference to last node

    // start --> 10 --> 20 --> 30 --> 40 --> 50 --> null
    // n = Head
    // while (n.Next != null)
    //  n = n.Next;


    // Find reference to second last node
    // while (n.Next.Next != null)
    //  n = n.Next;

    // Find reference to a node with particular info

    // Finding reference to predecessor of a node with particular info
    // while (n.Next != null)
    // if (n.next.data == x) break;     n = n.Next;

    // finding reference to a node at a particular position

    //********************************
    // 1. Inserting node at the begining of the list
    // Node temp = new Node(data);
    // temp.Next = head
    // head = temp

    //Inserting at the begining of the list
    // head = temp

    //Inserting at the end of the list
    // Get the reference to end last node of the list
    // while (n.Next != null) n = n.Next
    // n.Next = temp




    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
        }

        public void DisplayList()
        {
            Node n;
            
            if (Head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Console.WriteLine("The list is");
            n = Head;

            while( n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            Node n = Head;
            int count = 0;

            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }

            while (n != null)
            {
                count++;
                n = n.Next;
            }
            Console.WriteLine("Number of nodes in list" + count);
        }

        public void Search(int num)
        {
            Node n = Head;
            int position = 0;

            while (n!= null)
            {
                if (n.Data == num)
                {
                    Console.WriteLine("Found number at position: " + position);
                    break;
                }
                position++;
                n = n.Next;
            }

            if (n == null)
            {
                Console.WriteLine("Number not number atin list");
            }
        }

        public void InsertatBegining(int num)
        {
            Node temp = new Node(num);
            temp.Next = Head;
            Head = temp;
        }

        public void InsertatEndOfList(int num)
        {
            Node n;
            Node temp = new Node(num);

            if (Head == null)
            {
                Head = temp;
                return;
            }

            n = Head;
            while (n.Next != null)
            {
                n = n.Next;
            }

            n.Next = temp;
        }

        public void CreateList()
        {
            int n, intNum;

            Console.WriteLine("Enter number of nodes");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter elements to be inserted:");
                intNum = Convert.ToInt32(Console.ReadLine());
                InsertatEndOfList(intNum);
            }
        }
    }

}
