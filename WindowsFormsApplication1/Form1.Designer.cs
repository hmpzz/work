namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.GroupBox1);
            this.tabPage1.Controls.Add(this.Button1);
            this.tabPage1.Controls.Add(this.TextBox2);
            this.tabPage1.Controls.Add(this.TextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "格式化SQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "变量名";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(520, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 14;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(520, 202);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(106, 101);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Checked = true;
            this.RadioButton2.Location = new System.Drawing.Point(11, 54);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(35, 16);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "C#";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(11, 20);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(35, 16);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.Text = "VB";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(508, 15);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(113, 39);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "确定";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(27, 199);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox2.Size = new System.Drawing.Size(466, 191);
            this.TextBox2.TabIndex = 8;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(27, 15);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(466, 178);
            this.TextBox1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.Button3);
            this.tabPage2.Controls.Add(this.CheckBox1);
            this.tabPage2.Controls.Add(this.Button2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.ComboBox1);
            this.tabPage2.Controls.Add(this.TextBox7);
            this.tabPage2.Controls.Add(this.TextBox6);
            this.tabPage2.Controls.Add(this.TextBox5);
            this.tabPage2.Controls.Add(this.TextBox4);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.Label7);
            this.tabPage2.Controls.Add(this.Label6);
            this.tabPage2.Controls.Add(this.Label5);
            this.tabPage2.Controls.Add(this.Label4);
            this.tabPage2.Controls.Add(this.Label3);
            this.tabPage2.Controls.Add(this.Label2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "导出JSON";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(472, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 40;
            this.checkBox2.Text = "JSON忽略空值";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(544, 17);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 41);
            this.Button3.TabIndex = 39;
            this.Button3.Text = "生成JSON";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Location = new System.Drawing.Point(382, 85);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(84, 16);
            this.CheckBox1.TabIndex = 37;
            this.CheckBox1.Text = "只生成一条";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(463, 17);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 41);
            this.Button2.TabIndex = 36;
            this.Button2.Text = "生成SQL";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 35;
            this.button4.Text = "连接";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(78, 85);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(282, 20);
            this.ComboBox1.TabIndex = 34;
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(78, 184);
            this.TextBox7.Multiline = true;
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox7.Size = new System.Drawing.Size(487, 59);
            this.TextBox7.TabIndex = 33;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(78, 116);
            this.TextBox6.Multiline = true;
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox6.Size = new System.Drawing.Size(487, 59);
            this.TextBox6.TabIndex = 32;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(78, 48);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(100, 21);
            this.TextBox5.TabIndex = 31;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(78, 17);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(100, 21);
            this.TextBox4.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(21, 255);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox8.Size = new System.Drawing.Size(544, 228);
            this.textBox8.TabIndex = 29;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(260, 48);
            this.textBox9.Name = "textBox9";
            this.textBox9.PasswordChar = '#';
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 28;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(260, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 27;
            this.textBox10.Text = "sa";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(19, 184);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(41, 12);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "条件：";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(19, 116);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 12);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "列名：";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(43, 88);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 12);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "表：";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(201, 51);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 12);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "密码：";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(19, 51);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 12);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "数据库：";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(201, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 12);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "用户名：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "服务器：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox textBox8;
        internal System.Windows.Forms.TextBox textBox9;
        internal System.Windows.Forms.TextBox textBox10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.CheckBox checkBox2;
    }
}

