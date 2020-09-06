using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
   public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(Node next, int data)
        {
            this.Next = next;
            this.Data = data;
        }

        public Node(int data)
        {
            this.Next = null;
            this.Data = data;
        }

        //GetNext
        //SetNext
        //GetData
        //SetData

        public Node GetNext()
        {
            return Next;
        }

        public void SetNext(Node next)
        {
            this.Next = next;
        }

        public int GeEData()
        {
            return Data;
        }

        public void SetData(int data)
        {
            this.Data = data;
        }

    }
}
