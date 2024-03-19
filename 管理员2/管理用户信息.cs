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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“校园失物招领系统DataSet4.用户”中。您可以根据需要移动或删除它。
            this.用户TableAdapter.Fill(this.校园失物招领系统DataSet4.用户);

        }

        private void button1_Click(object sender, EventArgs e) //查询用户信息
        {
            if (this.textBox1.Text == "")
                MessageBox.Show("请输入查询的用户账号！","提示");
            else
            {
                string strsql = " select * from 用户 where 账号 like '%" + textBox1.Text + "%'";
                //创建并实例化SqlConnection
                SqlConnection conn =
                new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
                //  ew SqlConnection("server=.;uid=sa;pwd=111111;database=学生信息库
                SqlCommand cmd = new SqlCommand(strsql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //创建DataSet用来存储数据
                DataSet ds = new DataSet();
                //将数据填充到DataSet中
                da.Fill(ds);
                //在DataGirdView中显示
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e) //添加用户信息
        {
            try
            {
                string str = "server=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string stj;
                if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    SqlCommand cmd1 = new SqlCommand("select count(*) from 用户 where 账号='" + textBox4.Text + "'", conn);
                    int b = Convert.ToInt32(cmd1.ExecuteScalar());
                    if (b < 1)
                    {
                        stj = "insert into 用户(昵称,姓名,联系方式) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                        SqlCommand cmd = new SqlCommand(stj, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加成功!", "提示");
                        DataSet dsl1 = new DataSet();
                        SqlDataAdapter sda1;
                        sda1 = new SqlDataAdapter("Select 昵称,姓名,联系方式 from 用户 where 认领成功数!=0", conn);
                        sda1.Fill(dsl1);
                        dataGridView1.DataSource = dsl1.Tables[0];
                        dataGridView2.DataSource = dsl1.Tables[0];

                        conn.Close();
                    }
                    if (b >= 1)
                    {
                        MessageBox.Show("该用户已存在！", "提示");
                        textBox1.Text = "";
                    }
                }
                else { MessageBox.Show("添加失败!", "提示"); }

                conn.Close();
            }
            catch
            {
                MessageBox.Show("一个用户只能绑定一个联系方式！", "提示");
            }
        }

        private void button3_Click(object sender, EventArgs e) //刷新界面
        {
            string strsql = " select * from 用户 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)//删除用户信息
        {
            try
            {
                string str = "Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if (textBox5.Text == "")
                {
                    MessageBox.Show("请输入要删除的用户账号", "提示");
                }
                if (textBox5.Text != "")
                {
                    string a = "select count(*) from 用户 where 账号='" + textBox5.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(a, conn);
                    int s = Convert.ToInt32(cmd3.ExecuteScalar());
                    if (s > 0)
                    {
                        SqlCommand cmd6 = new SqlCommand("select count(*) from 用户 where 账号='" + textBox5.Text + "'", conn);
                        int c = Convert.ToInt32(cmd6.ExecuteScalar());
                        if (c > 0)
                        {
                            SqlCommand cmd = new SqlCommand("delete from 用户 where 账号='" + textBox5.Text + "'", conn);
                            cmd.ExecuteNonQuery();
                            SqlCommand cmd1 = new SqlCommand("delete from 用户 where 账号='" + textBox5.Text + "'", conn);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("删除成功!", "提示");
                        }
                        if (c < 1)
                        {
                            SqlCommand cmd = new SqlCommand("delete from 用户 where 账号='" + textBox5.Text + "'", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除成功!", "提示");
                        }

                        DataSet dsl1 = new DataSet();
                        SqlDataAdapter sda1;
                        sda1 = new SqlDataAdapter("Select 账号 from 用户 ", conn);
                        sda1.Fill(dsl1);
                        dataGridView3.DataSource = dsl1.Tables[0];
                        dataGridView1.DataSource = dsl1.Tables[0];
                        SqlDataAdapter sda = new SqlDataAdapter("select 姓名 from 用户 ", conn);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        comboBox1.DataSource = ds.Tables[0];
                        comboBox1.DisplayMember = "姓名";
                        comboBox1.ValueMember = "姓名";
                        conn.Close();
                    }
                    if (s < 1)
                    {
                        MessageBox.Show("无此用户账号!", "提示");
                        textBox2.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("错误", "提示");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //删除用户信息时的校对查询
        {
            string str = "Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            DataSet dsl = new DataSet();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter("Select * from 用户 where 姓名 like'" + comboBox1.Text + "' and 联系方式 like '%" + textBox6.Text + "%'", conn);
            sda.Fill(dsl);
            dataGridView3.DataSource = dsl.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e) //刷新界面
        {
            string strsql = " select * from 用户 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e) //刷新界面
        {
            string strsql = " select * from 用户 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }

    }
}
