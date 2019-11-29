//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PJ_Dictionary
//{
//    public struct aboutWord
//    {
//        public string word;
//        public string pronunciation;
//        public string wordType;
//        public string mean;
//    }
//    public class Node
//    {
//        public aboutWord data; 
//        public int height;
//        public Node pLeft, pRight;

//        public Node(aboutWord key)
//        {
//            data = key;
//            height = 1;
//        }
//    }

//    public class AVLTree
//    {

//        Node root;

//        // A utility function to get 
//        // the height of the tree  
//        int height(Node N)
//        {
//            if (N == null)
//                return 0;

//            return N.height;
//        }

//        // A utility function to get 
//        // maximum of two integers  
//        int max(int a, int b)
//        {
//            return (a > b) ? a : b;
//        }

//        // A utility function to right  
//        // rotate subtree rooted with y  
//        // See the diagram given above.  
//        Node rightRotate(Node y)
//        {
//            Node x = y.pLeft;
//            Node T2 = x.pRight;

//            // Perform rotation  
//            x.pRight = y;
//            y.pLeft = T2;

//            // Update heights  
//            y.height = max(height(y.pLeft),
//                        height(y.pRight)) + 1;
//            x.height = max(height(x.pLeft),
//                        height(x.pRight)) + 1;

//            // Return new root  
//            return x;
//        }

//        // A utility function to left 
//        // rotate subtree rooted with x  
//        // See the diagram given above.  
//        Node leftRotate(Node x)
//        {
//            Node y = x.pRight;
//            Node T2 = y.pLeft;

//            // Perform rotation  
//            y.pLeft = x;
//            x.pRight = T2;

//            // Update heights  
//            x.height = max(height(x.pLeft),
//                        height(x.pRight)) + 1;
//            y.height = max(height(y.pLeft),
//                        height(y.pRight)) + 1;

//            // Return new root  
//            return y;
//        }

//        // Get Balance factor of node N  
//        int getBalance(Node N)
//        {
//            if (N == null)
//                return 0;

//            return height(N.pLeft) - height(N.pRight);
//        }

//        Node insert(Node node, aboutWord key)
//        {

//            /* 1. Perform the normal BST insertion */
//            if (node == null)
//                return (new Node(key));

//            if (String.Compare(key.word, node.data.word, true) < 0)
//                node.pLeft = insert(node.pLeft, key);
//            else if (String.Compare(key.word, node.data.word, true) > 0)
//                node.pRight = insert(node.pRight, key);
//            else // Duplicate keys not allowed  
//                return node;

//            /* 2. Update height of this ancestor node */
//            node.height = 1 + max(height(node.pLeft),
//                                height(node.pRight));

//            /* 3. Get the balance factor of this ancestor  
//                node to check whether this node became  
//                unbalanced */
//            int balance = getBalance(node);

//            // If this node becomes unbalanced, then there  
//            // are 4 cases Left Left Case  
//            if (balance > 1 && string.Compare(key.word, node.pLeft.data.word) < 0) 
//                return rightRotate(node);

//            // Right Right Case  
//            if (balance < -1 && string.Compare(key.word, node.pRight.data.word) > 0)
//                return leftRotate(node);

//            // Left Right Case  
//            if (balance > 1 && string.Compare(key.word, node.pLeft.data.word) > 0)
//            {
//                node.pLeft = leftRotate(node.pLeft);
//                return rightRotate(node);
//            }

//            // Right Left Case  
//            if (balance < -1 && string.Compare(key.word, node.pRight.data.word) < 0)
//            {
//                node.pRight = rightRotate(node.pRight);
//                return leftRotate(node);
//            }

//            /* return the (unchanged) node pointer */
//            return node;
//        }


//    }
//}
