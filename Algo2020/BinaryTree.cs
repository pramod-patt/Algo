using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Algo2020
{
    public class BinaryTree
    {
        private TreeNode root;
        private TreeNode prev = null;

        public void Insert(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                return;
            }
           TreeNode prev = null;
           TreeNode curr = root;
           while (curr != null)
            {
                if (data == curr.Data)
                {
                    Console.WriteLine("Data already exists");
                }
                else if (data < curr.Data)
                {
                    prev = curr;
                    curr = curr.LeftChild;
                }
                else
                {
                    prev = curr;
                    curr = curr.RightChild;
                }

                if (data < prev.Data)
                {
                    prev.LeftChild = new TreeNode(data);
                }
                else
                {
                    prev.RightChild = new TreeNode(data);
                }
            }

        }
        /// <summary>
        ///  Binary search tree (Search)
        /// </summary>
        /// <param name="val"></param>
        public void Search(int val)
        {
            if (root == null)
                return;
            TreeNode curr = root;
             
            while (curr != null)
            {
                if (curr.Data == val)
                {
                    Console.WriteLine("Found the result " + curr.Data);
                }
                //move right
                else if (curr.Data < val)
                {
                    curr = curr.RightChild;
                }
                else if (curr.Data > val)
                {
                    curr = curr.LeftChild;
                }
            }
        }



        // preorder = {3.9.20,15,7}
        // Inorder = {9,3,15,20,7}
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int preIndex = 0;
        public TreeNode BuildTreefromPreOrderInOrder(int[] inOrderArray, int[] preOrderArray)
        {
            // HashTable<int, int> hs = new HashTable<int, int>();
          
            // add all the value from inorder to hashtable
            for (int i = 0; i < inOrderArray.Length; i++)
            {
                dict.Add(inOrderArray[i], i);
            }
            
            return Build(inOrderArray, preOrderArray, 0, inOrderArray.Length - 1);
        }
       

        private TreeNode Build(int[] inOrderArray, int[] preOrderArray, int start, int end)
        {
            if (start > end)
                return null;

            TreeNode root = new TreeNode(preOrderArray[preIndex++]);

            if (root == null)
                return null;

            if (start == end)
                return root;

            int index = dict[root.Data];
            root.LeftChild = Build(inOrderArray, preOrderArray, start, index);
            root.RightChild = Build(inOrderArray, preOrderArray, index+1, end);

            return root;
        }

        
        /// <summary>
        /// BFS (Breadth first search)
        /// </summary>
        public void LevelOrderTraversal(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                TreeNode n = q.Dequeue();

                if (n.LeftChild != null)
                    q.Enqueue(n.LeftChild);

                if (n.RightChild != null)
                    q.Enqueue(n.RightChild);
            }
            
        }

    }
    ///// <summary>
    ///// N-ary tree level order traversal
    ///// Instead of left right, loop through all the childs
    ///// </summary>
    //public void NaryLevelOrderTraversal()
    //{

    //}

    ///// <summary>
    ///// Zig zag traversal
    ///// R--> L L--> R
    ///// </summary>
    //public void ZigZagTraversal()
    //{

    //}

    ///// <summary>
    ///// Path Sum
    ///// use DFS (Preorder) top down approach
    ///// </summary>
    //public void PathSum()
    //{

    //}

    public class TreeNode
    {
        public int Data { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }

        public TreeNode(int val)
        {
            this.Data = val;
            this.LeftChild = null;
            this.RightChild = null;
        }

        public void Insert(int value)
        {
            TreeNode curr = this;

            TreeNode prev = null;
            while (curr != null)
            {
                if (value == curr.Data)
                {
                    Console.WriteLine("Data already exists");
                }
                else if (value < curr.Data)
                {
                    prev = curr;
                    curr = curr.LeftChild;
                }
                else
                {
                    prev = curr;
                    curr = curr.RightChild;
                }
            } 
                
            if (value < prev.Data)
            {
                prev.LeftChild = new TreeNode(value);

            }
            else
            {
                prev.RightChild = new TreeNode(value);

            }
        }

        public void Search(int val)
        {            
            TreeNode curr = this;

            if (curr == null)
                return;

            while (curr != null)
            {
                if (curr.Data == val)
                {
                    Console.WriteLine("Found the result " + curr.Data);
                    return;
                }
                //move right
                else if (curr.Data < val)
                {
                    curr = curr.RightChild;
                }
                else if (curr.Data > val)
                {
                    curr = curr.LeftChild;
                }
            }
        }

        /// <summary>
        /// Time complexity o(log n)
        /// space complexity o(height)
        /// </summary>
        /// <returns></returns>
        public int FindMin() {

            TreeNode curr = this;

            if (curr == null)
                return -1;

            while (curr.LeftChild != null)
            {
                curr = curr.LeftChild;
            }

            return curr.Data;        
        }

        public int FindMax()
        {
            TreeNode currr = this;

            if (currr == null)
                return -1;

            while (currr.RightChild != null)
            {
                currr = currr.RightChild;
            }

            return currr.Data;
        }

        /// 1. Successor of a node will be found in the right subtree and the minimum element in the right subtree
        /// 2. if the node doesn't have right subtree and look up in the ancestor and record the element where it moved left. That ancestor is the successor of that node
        /// 
        public int FindSuccessor(int val)
        {
            TreeNode curr = this;
            int result = -1;

            if (curr.RightChild != null)
            {
                curr = curr.RightChild;
                //find minimum in the right child
                while(curr.LeftChild != null)
                {
                    curr = curr.LeftChild;
                }
            }

            result = curr.Data;

            // Condition 2 (Find the value of the node that we are trying to find)

            TreeNode ancestor = null;
            while (curr.Data != val)
            {
                if (curr.Data > val)
                {
                    ancestor = curr;
                    curr = curr.LeftChild;
                }
                else
                {
                    curr = curr.RightChild;
                }
            }

            result = ancestor.Data;

            return result;
        }

        /// <summary>
        /// Case - 1 if the node is leaf node --> curr.left == null and curr.right == null
        ///  Search for the node
        ///  Record prev node
        /// find of curr node is left or right child of prev node
        /// if left child then make prev.left = null
        /// if right child then male prev,right = null
        /// </summary>
        /// <param name="val"></param>
        public void Delete(int val)
        {
            TreeNode curr = this;

            if (curr == null)
            {
                return;
            }
            TreeNode prev = null;
            while (curr != null)
            {
                if (curr.Data == val)
                {
                    prev = curr;
                    Console.WriteLine("Found the node" + val);
                }                
                else if (val < curr.Data)
                {
                    prev = curr;
                    curr = curr.LeftChild;
                }
                else
                {
                    prev = curr;
                    curr = curr.RightChild;
                }
            }

            //leaf node
            if (curr.LeftChild == null && curr.RightChild == null)
            {
                if (prev.LeftChild == curr)
                {
                    prev.LeftChild = null;
                }

                if (prev.RightChild  == null)
                {
                    prev.RightChild = null;
                }
            }

        }


    }
}
