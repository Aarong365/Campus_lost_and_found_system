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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“校园失物招领系统DataSet4.用户”中。您可以根据需要移动或删除它。
            this.用户TableAdapter.Fill(this.校园失物招领系统DataSet4.用户);
            // TODO: 这行代码将数据加载到表“校园失物招领系统DataSet4.物品”中。您可以根据需要移动或删除它。
            this.物品TableAdapter.Fill(this.校园失物招领系统DataSet4.物品);
            

        }

        private void button1_Click(object sender, EventArgs e) //查询物品信息
        {
            if (this.textBox1.Text == "")
                MessageBox.Show("请输入需要查询的物品id！","提示");
            else
            {
                string strsql = "Select * from 物品 where 物品id like '%" + textBox1.Text + "%'";
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(strsql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        
        private void button2_Click(object sender, EventArgs e) //添加物品信息
        {
            string str = "Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=true";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string stj;
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && textBox6.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("select count(*) from 物品 where 物品id=null", conn);
                int b = Convert.ToInt32(cmd1.ExecuteScalar());
                if (b < 1)
                {
                    // string a;
                    // a = dateTimePicker1.Value.ToString("yyyy/mm/dd");
                    stj = "insert into 物品(案件性质,种类,时间,区域,物品状态,发布账号) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Value.ToString("d") + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox6.Text + "')";
                    SqlCommand cmd = new SqlCommand(stj, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功!", "提示");
                    DataSet dsl1 = new DataSet();
                    SqlDataAdapter sda1;
                    sda1 = new SqlDataAdapter("Select * from 物品 ", conn);
                    sda1.Fill(dsl1);
                    dataGridView1.DataSource = dsl1.Tables[0];
                    dataGridView2.DataSource = dsl1.Tables[0];
                    conn.Close();
                }
                if (b >= 1)
                {
                    MessageBox.Show("该物品已存在！", "提示");
                    comboBox1.Text = "";
                }
            }
            else { MessageBox.Show("添加失败!", "提示"); }
            conn.Close();


        }

        private void button3_Click(object sender, EventArgs e) //删除物品信息
        {
            try
            {
                if (this.textBox7.Text == "")
                    MessageBox.Show("请输入需要删除的物品信息！","提示");
                else
                {
                    string strsql = " delete from 物品 where 物品id like '%" + textBox7.Text + "%'";
                    //创建并实例化SqlConnection
                    SqlConnection conn =
                    new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(strsql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //创建DataSet用来存储数据
                    DataSet ds = new DataSet();
                    //将数据填充到DataSet中
                    da.Fill(ds);
                    //在DataGirdView中显示
                    MessageBox.Show("已成功删除！", "提示");
                    dataGridView3.DataSource = ds.Tables[0];
                }  
            }
            catch
            {
                MessageBox.Show("完成！","提示");
            }
          
        }

        private void button6_Click(object sender, EventArgs e) //刷新界面
        {
            string strsql = " select * from 物品 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strsql = " select * from 物品 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strsql = " select * from 物品 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e) //修改物品状态信息
        {
            try
            {
                if (this.textBox8.Text == "" || this.comboBox5.Text == "")
                    MessageBox.Show("请输入修改内容！", "提示");
                else
                {
                    string strsql = "update 物品 set 物品状态 = '" + comboBox5.Text + "'where 物品id = '" + textBox8.Text + "'";
                    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(strsql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("已成功修改物品状态！", "提示");
                    }
                    dataGridView4.DataSource = ds.Tables[0];
                    MessageBox.Show("已成功修改物品状态！", "提示");
                }
            }
            catch
            {
                MessageBox.Show("修改成功！", "提示");
            }
            
        }

        private void button8_Click(object sender, EventArgs e) //刷新界面
        {
            string strsql = " select * from 物品 ";
            SqlConnection conn =
            new SqlConnection("Data Source=.;Initial Catalog=校园失物招领系统;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
        }

    }
}
