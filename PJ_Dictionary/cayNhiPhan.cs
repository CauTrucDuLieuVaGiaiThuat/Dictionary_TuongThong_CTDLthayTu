using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PJ_Dictionary
{
    public struct aboutWord
    {
        public string word;
        public string pronunciation;
        public string wordType;
        public string mean;
    }
    public class Node
    {
        public aboutWord data;
        public Node pLeft;
        public Node pRight;

        public Node(aboutWord key)
        {
            data = key;
            pLeft = pRight = null;
        }   
        public void Insert(aboutWord key)
        {
            if (String.Compare(key.word, data.word, true) == 0)
                return;
            else if(String.Compare(key.word, data.word, true) < 0)
            {
                if (pLeft == null)
                    pLeft = new Node(key);
                else
                    pLeft.Insert(key);
            }
            else
            {
                if (pRight == null)
                    pRight = new Node(key);
                else
                    pRight.Insert(key);
            }
        }
    }

    public class TREE
    {
        public Node root;
        public TREE()
        {
            root = null;
        }

        public void InsertNode(aboutWord key)
        {
            if (root == null)
                root = new Node(key);
            else
                root.Insert(key);   
        }

        public Node Search(Node node, string key)
        {
            if (node == null)
                return null;
            if (string.Compare(key, node.data.word) == 0)
                return node;
            else if (string.Compare(key, node.data.word) < 0)
                return Search(node.pLeft, key);
            else if (string.Compare(key, node.data.word) > 0)
                return Search(node.pRight, key);
            else
                return null;
        }
    }

}
