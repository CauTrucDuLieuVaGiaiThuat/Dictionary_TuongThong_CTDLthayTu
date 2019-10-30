using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PJ_Dictionary
{
    //Khai báo kiểu dữ liệu struct cho từ điển
    public struct aboutWord
    {
        public string word;     
        public string pronunciation;
        public string wordType;
        public string mean;
    }

    //Khởi tạo class Node
    public class Node
    {
        public aboutWord data;
        public Node pLeft;
        public Node pRight;

        //Tạo một node mới với khóa là Key, không nhánh
        public Node(aboutWord key)
        {
            data = key;
            pLeft = pRight = null;
        }

        //Them các nút con
        /*public void Insert(aboutWord key)
        {
            if (String.Compare(key.word, data.word, true) == 0)
                return;
            else if (String.Compare(key.word, data.word, true) < 0)
            {
                if (pLeft == null)
                {
                    pLeft = new Node(key);
                }
                else
                    pLeft.Insert(key);
            }
            else
            {
                if (pRight == null)
                {
                    pRight = new Node(key);
                }  
                else
                    pRight.Insert(key);
            }
        }*/
    }

    public class TREE
    {
        //public FileStream fa = new FileStream(@"TuDien.txt", FileMode.Create);
        //public StreamWriter wr = new StreamWriter(fa, Encoding.Unicode);


        public Node root;

        //Khởi tạo cây rỗng
        public TREE()
        {
            root = null;
        }

        //Thêm nút gốc vào cây
        /*public void InsertNode(aboutWord key)
        {
            if (root == null)
            {
                root = new Node(key);
            }     
            else
                root.Insert(key);
        }*/
        public int InsertNode(ref Node T, aboutWord key)
        {
            if (T != null)
            {
                if (String.Compare(key.word, T.data.word, true) == 0)
                {
                    return 0;
                }

                else if (String.Compare(key.word, T.data.word, true) < 0)
                    return InsertNode(ref T.pLeft, key);
                else
                    return InsertNode(ref T.pRight, key);
            }
            Node temp = new Node(key);

            T = temp;
            Console.WriteLine("1");
            return 1;
        }

        public void DiTimNodeTheMang(ref Node X,ref Node Y)
        {
            if (Y.pLeft != null)
                DiTimNodeTheMang(ref X,ref Y.pLeft);
            else
            {
                X.data = Y.data;
                X = Y;
                Y = Y.pRight;
            }
        }

        public void DeleteNode(ref Node node, string key)
        {
            if (node == null)
                return;
            else
            {
                if (String.Compare(key, node.data.word, true) < 0)
                    DeleteNode(ref node.pLeft, key);
                else if (String.Compare(key, node.data.word, true) > 0)
                    DeleteNode(ref node.pRight, key);
                else
                {
                    Node X = node;
                    if (node.pLeft == null)
                        node = node.pRight;
                    else if (node.pRight == null)
                        node = node.pLeft;
                    else
                    {
                        DiTimNodeTheMang(ref X,ref node.pRight);
                    }
                    X = null;
                }
            }
        }

        /*public Node Search(Node node, string key)
        {
            if (node == null)   
                return null;
            else if (string.Compare(key, node.data.word) == 0)
                return node;
            else if (string.Compare(key, node.data.word) < 0)
                return Search(node.pLeft, key);
            else if (string.Compare(key, node.data.word) > 0)
                return Search(node.pRight, key);
            else
                return null;
        }*/
        public Node Search(Node node, string key)
        {
            Node p = node;
            while(p != null)
            {
                if (string.Compare(key, p.data.word) == 0)
                    return p;
                else if (string.Compare(key, p.data.word) < 0)
                    p = p.pLeft;
                else
                    p = p.pRight;
            }
            return null;
        }
       

        //Xuất các từ
        public void duyet_LNR(Node node1, StreamWriter wr)
        {
            if (node1 == null) return;

            wr.WriteLine(node1.data.word);
            wr.WriteLine(node1.data.pronunciation);
            wr.WriteLine(node1.data.wordType);
            wr.WriteLine(node1.data.mean);

            duyet_LNR(node1.pLeft, wr);
            duyet_LNR(node1.pRight, wr);
        }

        public void writeToFile(Node node)
        {
            StreamWriter wr = new StreamWriter(@"duLieuTuDien.txt", false, Encoding.UTF8);
            duyet_LNR(node, wr);
            wr.Close();
        }
    }
}
