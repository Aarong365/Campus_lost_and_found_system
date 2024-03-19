
namespace 管理员2
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.校园失物招领系统DataSet4 = new 管理员2.校园失物招领系统DataSet4();
            this.用户BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.账号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.昵称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信誉等级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.认领成功数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.校园失物招领系统DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.账号DataGridViewTextBoxColumn,
            this.密码DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.昵称DataGridViewTextBoxColumn,
            this.联系方式DataGridViewTextBoxColumn,
            this.信誉等级DataGridViewTextBoxColumn,
            this.认领成功数DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.用户BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(751, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(186, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(399, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "导出为Excel文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(335, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "导出数据";
            // 
            // 校园失物招领系统DataSet4
            // 
            this.校园失物招领系统DataSet4.DataSetName = "校园失物招领系统DataSet4";
            this.校园失物招领系统DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 用户BindingSource
            // 
            this.用户BindingSource.DataMember = "用户";
            this.用户BindingSource.DataSource = this.校园失物招领系统DataSet4;
            // 
            // 账号DataGridViewTextBoxColumn
            // 
            this.账号DataGridViewTextBoxColumn.DataPropertyName = "账号";
            this.账号DataGridViewTextBoxColumn.HeaderText = "账号";
            this.账号DataGridViewTextBoxColumn.Name = "账号DataGridViewTextBoxColumn";
            this.账号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 密码DataGridViewTextBoxColumn
            // 
            this.密码DataGridViewTextBoxColumn.DataPropertyName = "密码";
            this.密码DataGridViewTextBoxColumn.HeaderText = "密码";
            this.密码DataGridViewTextBoxColumn.Name = "密码DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 昵称DataGridViewTextBoxColumn
            // 
            this.昵称DataGridViewTextBoxColumn.DataPropertyName = "昵称";
            this.昵称DataGridViewTextBoxColumn.HeaderText = "昵称";
            this.昵称DataGridViewTextBoxColumn.Name = "昵称DataGridViewTextBoxColumn";
            // 
            // 联系方式DataGridViewTextBoxColumn
            // 
            this.联系方式DataGridViewTextBoxColumn.DataPropertyName = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.Name = "联系方式DataGridViewTextBoxColumn";
            // 
            // 信誉等级DataGridViewTextBoxColumn
            // 
            this.信誉等级DataGridViewTextBoxColumn.DataPropertyName = "信誉等级";
            this.信誉等级DataGridViewTextBoxColumn.HeaderText = "信誉等级";
            this.信誉等级DataGridViewTextBoxColumn.Name = "信誉等级DataGridViewTextBoxColumn";
            // 
            // 认领成功数DataGridViewTextBoxColumn
            // 
            this.认领成功数DataGridViewTextBoxColumn.DataPropertyName = "认领成功数";
            this.认领成功数DataGridViewTextBoxColumn.HeaderText = "认领成功数";
            this.认领成功数DataGridViewTextBoxColumn.Name = "认领成功数DataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "导出统计数据";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.校园失物招领系统DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 昵称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信誉等级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 认领成功数DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 用户BindingSource;
        private 校园失物招领系统DataSet4 校园失物招领系统DataSet4;
    }
}