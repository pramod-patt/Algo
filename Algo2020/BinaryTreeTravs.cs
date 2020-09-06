using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    public class BinaryTreeTravs
    {

        public void DFSTraversal(BTree node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.data);
            DFSTraversal(node.leftNode);
            DFSTraversal(node.rightNode);
            
        }

        //implement queue for Breadth first search
        public void BFSTraversal(BTree node)
        {
            if (node == null)
                return;

            Queue<BTree> q = new Queue<BTree>();

            q.Enqueue(node);

            while (q.Count > 0)
            {
                BTree current = q.Dequeue();
                Console.WriteLine(current.data);
                if (current.leftNode != null)
                    q.Enqueue(node.leftNode);

                if (current.rightNode != null)
                    q.Enqueue(node.rightNode);
            }
        }

    }


    public class BTree
    {
        public int data { get; set; }
        public BTree leftNode { get; set; }
        public BTree rightNode { get; set; }

        public BTree(int num)
        {
            this.data = num;
            this.leftNode = null;
            this.rightNode = null;
        }

    }
}
