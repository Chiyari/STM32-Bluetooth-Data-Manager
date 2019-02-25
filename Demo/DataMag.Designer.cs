namespace Demo
{
    partial class DataMag
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
            this.link_button = new System.Windows.Forms.Button();
            this.basename = new System.Windows.Forms.TextBox();
            this.tablename = new System.Windows.Forms.TextBox();
            this.adminname = new System.Windows.Forms.TextBox();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.baseadd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // link_button
            // 
            this.link_button.Location = new System.Drawing.Point(372, 125);
            this.link_button.Name = "link_button";
            this.link_button.Size = new System.Drawing.Size(122, 30);
            this.link_button.TabIndex = 0;
            this.link_button.Text = "连接数据库";
            this.link_button.UseVisualStyleBackColor = true;
            this.link_button.Click += new System.EventHandler(this.link_button_Click);
            // 
            // basename
            // 
            this.basename.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.basename.Location = new System.Drawing.Point(165, 125);
            this.basename.Name = "basename";
            this.basename.Size = new System.Drawing.Size(178, 25);
            this.basename.TabIndex = 1;
            this.basename.Text = "test";
            this.basename.Enter += new System.EventHandler(this.basename_Enter);
            // 
            // tablename
            // 
            this.tablename.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tablename.Location = new System.Drawing.Point(165, 168);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(178, 25);
            this.tablename.TabIndex = 2;
            this.tablename.Text = "data";
            this.tablename.Enter += new System.EventHandler(this.tablename_Enter);
            // 
            // adminname
            // 
            this.adminname.Location = new System.Drawing.Point(165, 211);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(178, 25);
            this.adminname.TabIndex = 3;
            // 
            // adminpass
            // 
            this.adminpass.Location = new System.Drawing.Point(165, 253);
            this.adminpass.Name = "adminpass";
            this.adminpass.PasswordChar = '*';
            this.adminpass.Size = new System.Drawing.Size(178, 25);
            this.adminpass.TabIndex = 4;
            // 
            // baseadd
            // 
            this.baseadd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.baseadd.Location = new System.Drawing.Point(165, 297);
            this.baseadd.Name = "baseadd";
            this.baseadd.Size = new System.Drawing.Size(178, 25);
            this.baseadd.TabIndex = 5;
            this.baseadd.Text = "127.0.0.1";
            this.baseadd.Enter += new System.EventHandler(this.baseadd_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "数据库名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "数据表名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "数据库地址";
            // 
            // DataMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseadd);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.adminname);
            this.Controls.Add(this.tablename);
            this.Controls.Add(this.basename);
            this.Controls.Add(this.link_button);
            this.Name = "DataMag";
            this.Text = "数据管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataMag_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button link_button;
        private System.Windows.Forms.TextBox basename;
        private System.Windows.Forms.TextBox tablename;
        private System.Windows.Forms.TextBox adminname;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.TextBox baseadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}