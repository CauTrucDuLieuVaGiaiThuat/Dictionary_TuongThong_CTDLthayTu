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
    public partial class Form3 : Form
    {
        aboutWord key = new aboutWord();
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_andNewTree_Click(object sender, EventArgs e)
        {
            andNew();
            MessageBox.Show("Thêm từ thành công!", "Thông báo!");
        }

        public void andNew()
        {
            key.word = tbx_word.Text;
            key.pronunciation = tbx_pronunciation.Text;
            key.wordType = tbx_wordType.Text;

            key.mean = "";
            if (tbx_mean1.Text != "")
                key.mean = tbx_mean1.Text;

            if (tbx_mean2.Text != "")
                key.mean = key.mean + "/" + tbx_mean2.Text;

            if (tbx_mean3.Text != "")
                key.mean = key.mean + "/" + tbx_mean3.Text;

            if (tbx_mean4.Text != "")
                key.mean = key.mean + "/" + tbx_mean4.Text;

            if (tbx_mean5.Text != "")
                key.mean = key.mean + "/" + tbx_mean5.Text;

            Form1.tree.InsertNode(key);
        }

        private void Btn_updateFile_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"duLieuTuDien.txt", true, Encoding.UTF8);
            wr.WriteLine(key.word);
            wr.WriteLine(key.pronunciation);
            wr.WriteLine(key.wordType);
            wr.WriteLine(key.mean);
            wr.Close();
            MessageBox.Show("Cập nhật vào file thành công", "Thông báo");
        }
    }
}
