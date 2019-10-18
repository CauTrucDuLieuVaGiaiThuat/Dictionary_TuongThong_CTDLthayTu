using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PJ_Dictionary
{
    //Khai báo kiểu dữ liệu cho từ điển
    public struct aboutWord
    {
        public string word;
        public string pronunciation;
        public string wordType;
        public string mean;
    }

    //Khai báo các nút
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
        public void Insert(aboutWord key)
        {
            if (String.Compare(key.word, data.word, true) == 0)
                return;
            else if (String.Compare(key.word, data.word, true) < 0)
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
        //public FileStream fa = new FileStream(@"TuDien.txt", FileMode.Create);
        //public StreamWriter wr = new StreamWriter(fa, Encoding.Unicode);


        public Node root;

        //Khởi tạo cây rỗng
        public TREE()
        {
            root = null;
        }

        //Thêm nút gốc vào cây
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

        //Xuất các từ
        public void duyet_LNR(Node node1, StreamWriter wr)
        {
            if (node1 == null) return;
            duyet_LNR(node1.pLeft, wr);

            wr.WriteLine(node1.data.word);
            wr.WriteLine(node1.data.pronunciation);
            wr.WriteLine(node1.data.wordType);
            wr.WriteLine(node1.data.mean);

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
