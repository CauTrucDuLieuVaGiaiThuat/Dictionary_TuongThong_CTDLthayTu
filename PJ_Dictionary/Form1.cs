using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PJ_Dictionary
{
    public partial class Form1 : Form
    {
        Form2 form2 = null;
        Form3 form3 = null;

        public static TREE tree = new TREE();
        public static Node node1 = null;
        aboutWord aboutWord1 = new aboutWord();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load từ vào cây
            FileStream fs = new FileStream(@"duLieuTuDien.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            while ((aboutWord1.word = rd.ReadLine()) != null)
            {
                aboutWord1.pronunciation = rd.ReadLine();
                aboutWord1.wordType = rd.ReadLine();
                aboutWord1.mean = rd.ReadLine();
                tree.InsertNode(aboutWord1);
            }
            rd.Close();
        }

        public void Btn_Search_Click(object sender, EventArgs e)
        {
            bt_mean1.Visible = false;
            bt_mean2.Visible = false;
            bt_mean3.Visible = false;
            bt_mean4.Visible = false;
            bt_mean5.Visible = false;
            lb_Mean1.Text = "";
            lb_Mean2.Text = "";
            lb_Mean3.Text = "";
            lb_Mean4.Text = "";
            lb_Mean5.Text = "";
            if(tbx_Nhaptu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập từ trước khi tìm kiếm", "Thông báo!");
            }
            else
            {
                node1 = tree.Search(tree.root, tbx_Nhaptu.Text);
                node1 = tree.Search(tree.root, tbx_Nhaptu.Text);
                if (node1 == null)
                {
                    lb_Word.Text = "Xin lỗi! Không có dữ liệu từ này."; ;
                    lb_WordType.Text = "";
                }
                else
                {
                    lb_Word.Text = node1.data.word + "    " + node1.data.pronunciation;
                    lb_WordType.Text = node1.data.wordType;

                    //string tempWord = procesString(node1.data.mean);
                    //lb_Mean1.Text = tempWord;

                    string tempMean = node1.data.mean;
                    string[] listMean = tempMean.Split('/'); // Hàm cắt chuỗi khi gặp '/'

                    int size = listMean.Length;

                    if (size >= 1)
                    {
                        lb_Mean1.Text = listMean[0];
                        bt_mean1.Visible = true;
                    }
                    if (size >= 2)
                    {
                        lb_Mean2.Text = listMean[1];
                        bt_mean2.Visible = true;
                    }
                    if (size >= 3)
                    {
                        lb_Mean3.Text = listMean[2];
                        bt_mean3.Visible = true;
                    }
                    if (size >= 4)
                    {
                        lb_Mean4.Text = listMean[3];
                        bt_mean4.Visible = true;
                    }
                    if (size >= 5)
                    {
                        lb_Mean5.Text = listMean[4];
                        bt_mean5.Visible = true;
                    }
                }
            }
            
        }

        private void Tbx_Nhaptu_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                Btn_Search_Click(sender,e);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            if(node1 == null)
            {
                MessageBox.Show("Bạn phải nhập từ trước khi cập nhật", "Thông báo!");
            }
            else
            {
                form2.showWord(node1);
                form2.Show();
            }  
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }
        public string procesString(string mean)
        {
            string tempMean = "";
            foreach (char Char in mean)
            {
                if (Char != '/')
                {
                    tempMean = tempMean + Char.ToString();
                }
                else
                {
                    tempMean = tempMean + "\n\n";
                }
            }
            return tempMean;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (tbx_Nhaptu.Text == "")
                MessageBox.Show("Nhập từ cần tìm trước khi xóa!", "Thông báo");
            else
            {
                aboutWord1.word = tbx_Nhaptu.Text;
                tree.DeleteNode(tree.root, aboutWord1.word);
                MessageBox.Show("Xóa từ thành công!", "Thông báo");
            }
        }
    }
}
