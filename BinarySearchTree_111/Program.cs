using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_111
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /*A node class consists of three things, the information, 
     * references to the right child, and references to the left child */

    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /* initializing ROOT to null */
        }   
    }
}
