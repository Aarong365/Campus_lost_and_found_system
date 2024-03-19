using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 管理员2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“校园失物招领系统DataSet4.认领关系”中。您可以根据需要移动或删除它。
            this.认领关系TableAdapter.Fill(this.校园失物招领系统DataSet4.认领关系);


        }

        private void button2_Click(object sender, EventArgs e) //删除已成功认领的物品信息
        {
            string str = "server=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string i = "select count(*) from 认领关系 where 账号='" + textBox1.Text + "' and 物品id='" + textBox2.Text + "'";
                SqlCommand cmd2 = new SqlCommand(i, conn);
                int b = Convert.ToInt32(cmd2.ExecuteScalar());
                if (b >= 1)
                {
                    string sql = "delete from 认领关系 where  账号='" + textBox1.Text + "' and 账号='" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update 认领关系 set 物品状态='已找回' where 物品id='" + textBox2.Text + "'", conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("删除成功!", "提示");
                    DataSet dsl = new DataSet();
                    SqlDataAdapter sda;
                    sda = new SqlDataAdapter("Select * from 认领关系", conn);
                    sda.Fill(dsl);
                    dataGridView1.DataSource = dsl.Tables[0];
                    DataSet dsl1 = new DataSet();
                    SqlDataAdapter sda1;
                    sda1 = new SqlDataAdapter("Select * from 认领关系 where 物品状态='已找回'", conn);
                    sda1.Fill(dsl1);
                    dataGridView1.DataSource = dsl1.Tables[0];
                    dataGridView2.DataSource = dsl1.Tables[0];
                    conn.Close();
                }
                if (b < 1) { MessageBox.Show("请输入正确的选项!", "提示"); }
            }
            else { MessageBox.Show("请输入删除完整信息！", "提示"); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string strsql = "Select * from 认领关系 where 物品状态='无人认领' and year(GETDATE())-时间>='1'";
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(strsql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e) //删除长期无人认领的物品信息
        {
            string str = "server=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            if (textBox3.Text != "")
            {
                string i = "select count(*) from 认领关系 where 物品id='" + textBox3.Text + "'";
                SqlCommand cmd2 = new SqlCommand(i, conn);
                int b = Convert.ToInt32(cmd2.ExecuteScalar());
                if (b >= 1)
                {
                    string sql = "delete from 认领关系 where 物品id='" + textBox3.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update 认领关系 set 物品状态='无人认领' where 物品id='" + textBox3.Text + "'", conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("删除成功!", "提示");
                    DataSet dsl = new DataSet();
                    SqlDataAdapter sda;
                    sda = new SqlDataAdapter("Select * from 认领关系", conn);
                    sda.Fill(dsl);
                    dataGridView1.DataSource = dsl.Tables[0];
                    DataSet dsl1 = new DataSet();
                    SqlDataAdapter sda1;
                    sda1 = new SqlDataAdapter("Select * from 认领关系 where 物品状态='无人认领'", conn);
                    sda1.Fill(dsl1);
                    dataGridView1.DataSource = dsl1.Tables[0];
                    dataGridView2.DataSource = dsl1.Tables[0];
                    conn.Close();
                }
                if (b < 1) { MessageBox.Show("请输入正确的选项!", "提示"); }
            }
            else { MessageBox.Show("请输入删除完整信息！", "提示"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "server=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            DataSet dsl = new DataSet();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("Select * from 认领关系 where 物品状态 = '已找回'", conn);
            sda.Fill(dsl);
            dataGridView1.DataSource = dsl.Tables[0];
        }
    }
}
