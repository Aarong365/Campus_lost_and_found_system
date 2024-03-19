
namespace 管理员2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.校园失物招领系统DataSet4 = new 管理员2.校园失物招领系统DataSet4();
            this.认领关系BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.认领关系TableAdapter = new 管理员2.校园失物招领系统DataSet4TableAdapters.认领关系TableAdapter();
            this.物品idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户账号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发布账号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.认领人账号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.认领关系BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.物品idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户账号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发布账号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.认领人账号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品状态DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.校园失物招领系统DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.认领关系BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.认领关系BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(40, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "删除已成功认领的发布信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "查询成功认领的物品";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(241, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "删除成功认领物品信息";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 445);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 21);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "账号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "物品id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物品idDataGridViewTextBoxColumn,
            this.用户账号DataGridViewTextBoxColumn,
            this.发布账号DataGridViewTextBoxColumn,
            this.认领人账号DataGridViewTextBoxColumn,
            this.时间DataGridViewTextBoxColumn,
            this.物品状态DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.认领关系BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(649, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除长期未曾认领的发布信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(248, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "删除长期未曾认领信息";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(252, 419);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 21);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "删除长期无人认领物品(输入物品id）";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "查询长期无人认领的物品";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物品idDataGridViewTextBoxColumn1,
            this.用户账号DataGridViewTextBoxColumn1,
            this.发布账号DataGridViewTextBoxColumn1,
            this.认领人账号DataGridViewTextBoxColumn1,
            this.时间DataGridViewTextBoxColumn1,
            this.物品状态DataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.认领关系BindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(43, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(646, 260);
            this.dataGridView2.TabIndex = 0;
            // 
            // 校园失物招领系统DataSet4
            // 
            this.校园失物招领系统DataSet4.DataSetName = "校园失物招领系统DataSet4";
            this.校园失物招领系统DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 认领关系BindingSource
            // 
            this.认领关系BindingSource.DataMember = "认领关系";
            this.认领关系BindingSource.DataSource = this.校园失物招领系统DataSet4;
            // 
            // 认领关系TableAdapter
            // 
            this.认领关系TableAdapter.ClearBeforeFill = true;
            // 
            // 物品idDataGridViewTextBoxColumn
            // 
            this.物品idDataGridViewTextBoxColumn.DataPropertyName = "物品id";
            this.物品idDataGridViewTextBoxColumn.HeaderText = "物品id";
            this.物品idDataGridViewTextBoxColumn.Name = "物品idDataGridViewTextBoxColumn";
            // 
            // 用户账号DataGridViewTextBoxColumn
            // 
            this.用户账号DataGridViewTextBoxColumn.DataPropertyName = "用户账号";
            this.用户账号DataGridViewTextBoxColumn.HeaderText = "用户账号";
            this.用户账号DataGridViewTextBoxColumn.Name = "用户账号DataGridViewTextBoxColumn";
            // 
            // 发布账号DataGridViewTextBoxColumn
            // 
            this.发布账号DataGridViewTextBoxColumn.DataPropertyName = "发布账号";
            this.发布账号DataGridViewTextBoxColumn.HeaderText = "发布账号";
            this.发布账号DataGridViewTextBoxColumn.Name = "发布账号DataGridViewTextBoxColumn";
            // 
            // 认领人账号DataGridViewTextBoxColumn
            // 
            this.认领人账号DataGridViewTextBoxColumn.DataPropertyName = "认领人账号";
            this.认领人账号DataGridViewTextBoxColumn.HeaderText = "认领人账号";
            this.认领人账号DataGridViewTextBoxColumn.Name = "认领人账号DataGridViewTextBoxColumn";
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            // 
            // 物品状态DataGridViewTextBoxColumn
            // 
            this.物品状态DataGridViewTextBoxColumn.DataPropertyName = "物品状态";
            this.物品状态DataGridViewTextBoxColumn.HeaderText = "物品状态";
            this.物品状态DataGridViewTextBoxColumn.Name = "物品状态DataGridViewTextBoxColumn";
            // 
            // 认领关系BindingSource1
            // 
            this.认领关系BindingSource1.DataMember = "认领关系";
            this.认领关系BindingSource1.DataSource = this.校园失物招领系统DataSet4;
            // 
            // 物品idDataGridViewTextBoxColumn1
            // 
            this.物品idDataGridViewTextBoxColumn1.DataPropertyName = "物品id";
            this.物品idDataGridViewTextBoxColumn1.HeaderText = "物品id";
            this.物品idDataGridViewTextBoxColumn1.Name = "物品idDataGridViewTextBoxColumn1";
            // 
            // 用户账号DataGridViewTextBoxColumn1
            // 
            this.用户账号DataGridViewTextBoxColumn1.DataPropertyName = "用户账号";
            this.用户账号DataGridViewTextBoxColumn1.HeaderText = "用户账号";
            this.用户账号DataGridViewTextBoxColumn1.Name = "用户账号DataGridViewTextBoxColumn1";
            // 
            // 发布账号DataGridViewTextBoxColumn1
            // 
            this.发布账号DataGridViewTextBoxColumn1.DataPropertyName = "发布账号";
            this.发布账号DataGridViewTextBoxColumn1.HeaderText = "发布账号";
            this.发布账号DataGridViewTextBoxColumn1.Name = "发布账号DataGridViewTextBoxColumn1";
            // 
            // 认领人账号DataGridViewTextBoxColumn1
            // 
            this.认领人账号DataGridViewTextBoxColumn1.DataPropertyName = "认领人账号";
            this.认领人账号DataGridViewTextBoxColumn1.HeaderText = "认领人账号";
            this.认领人账号DataGridViewTextBoxColumn1.Name = "认领人账号DataGridViewTextBoxColumn1";
            // 
            // 时间DataGridViewTextBoxColumn1
            // 
            this.时间DataGridViewTextBoxColumn1.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn1.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn1.Name = "时间DataGridViewTextBoxColumn1";
            // 
            // 物品状态DataGridViewTextBoxColumn1
            // 
            this.物品状态DataGridViewTextBoxColumn1.DataPropertyName = "物品状态";
            this.物品状态DataGridViewTextBoxColumn1.HeaderText = "物品状态";
            this.物品状态DataGridViewTextBoxColumn1.Name = "物品状态DataGridViewTextBoxColumn1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "管理认定信息";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.校园失物招领系统DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.认领关系BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.认领关系BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private 校园失物招领系统DataSet4 校园失物招领系统DataSet4;
        private System.Windows.Forms.BindingSource 认领关系BindingSource;
        private 校园失物招领系统DataSet4TableAdapters.认领关系TableAdapter 认领关系TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户账号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发布账号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 认领人账号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户账号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发布账号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 认领人账号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品状态DataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource 认领关系BindingSource1;
    }
}