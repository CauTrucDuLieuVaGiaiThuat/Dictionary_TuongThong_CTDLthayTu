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
    public partial class Form1 : Form
    {
        Form2 form2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        public void Btn_Search_Click(object sender, EventArgs e)
        {
            lb_Word.Text = "Đặng Thị Ngọc Hân";
            lb_WordType.Text = "Ốc Hân";
            lb_Mean1.Text = "Heo";
            lb_Mean2.Text = "Ăn";
            lb_Mean3.Text = "Cám";

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
            form2.Show();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }
    }
}
