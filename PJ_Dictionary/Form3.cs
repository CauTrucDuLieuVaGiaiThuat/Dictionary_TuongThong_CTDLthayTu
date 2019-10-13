using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_Dictionary
{
    public partial class Form3 : Form
    {
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
            aboutWord key = new aboutWord();
            key.word = tbx_word.Text;
            key.pronunciation = tbx_pronunciation.Text;
            key.wordType = tbx_wordType.Text;
            key.mean = tbx_mean1.Text + "/" + tbx_mean2.Text + "/" + tbx_mean3.Text + "/" + tbx_mean4.Text + "/" + tbx_mean5.Text;
            Form1.tree.InsertNode(key);
        }
    }
}
