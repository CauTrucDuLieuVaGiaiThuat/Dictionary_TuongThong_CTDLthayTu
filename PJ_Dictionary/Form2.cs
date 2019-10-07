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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Lb_mean_Load(object sender, EventArgs e)
        {
            tbx_word.Text = "apple";
            tbx_wordType.Text = "noun";
            tbx_mean1.Text = "quả táo";
        }
    }
}
