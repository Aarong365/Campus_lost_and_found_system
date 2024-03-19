using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 管理员2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//用户信息
        {
            Form2 nf = new Form2();
            nf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//物品信息
        {
            Form3 nf = new Form3();
            nf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//认定信息
        {
            Form4 nf = new Form4();
            nf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//导出统计数据
        {
            Form5 nf = new Form5();
            nf.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
