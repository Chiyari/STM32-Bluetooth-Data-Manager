namespace Demo
{
    partial class Devices
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
            this.discover_device = new System.Windows.Forms.Button();
            this.device_msg = new System.Windows.Forms.TextBox();
            this.device_list = new System.Windows.Forms.ListBox();
            this.return_main = new System.Windows.Forms.Button();
            this.pair_device = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // discover_device
            // 
            this.discover_device.Location = new System.Drawing.Point(365, 20);
            this.discover_device.Name = "discover_device";
            this.discover_device.Size = new System.Drawing.Size(123, 33);
            this.discover_device.TabIndex = 0;
            this.discover_device.Text = "查找设备";
            this.discover_device.UseVisualStyleBackColor = true;
            this.discover_device.Click += new System.EventHandler(this.discover_device_Click);
            // 
            // device_msg
            // 
            this.device_msg.Location = new System.Drawing.Point(12, 150);
            this.device_msg.Name = "device_msg";
            this.device_msg.ReadOnly = true;
            this.device_msg.Size = new System.Drawing.Size(347, 25);
            this.device_msg.TabIndex = 1;
            // 
            // device_list
            // 
            this.device_list.FormattingEnabled = true;
            this.device_list.ItemHeight = 15;
            this.device_list.Location = new System.Drawing.Point(12, 20);
            this.device_list.Name = "device_list";
            this.device_list.Size = new System.Drawing.Size(347, 124);
            this.device_list.TabIndex = 2;
            // 
            // return_main
            // 
            this.return_main.Location = new System.Drawing.Point(12, 181);
            this.return_main.Name = "return_main";
            this.return_main.Size = new System.Drawing.Size(123, 33);
            this.return_main.TabIndex = 3;
            this.return_main.Text = "返回主界面";
            this.return_main.UseVisualStyleBackColor = true;
            this.return_main.Click += new System.EventHandler(this.return_main_Click);
            // 
            // pair_device
            // 
            this.pair_device.Location = new System.Drawing.Point(365, 59);
            this.pair_device.Name = "pair_device";
            this.pair_device.Size = new System.Drawing.Size(123, 34);
            this.pair_device.TabIndex = 4;
            this.pair_device.Text = "设备配对";
            this.pair_device.UseVisualStyleBackColor = true;
            this.pair_device.Click += new System.EventHandler(this.pair_device_Click);
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pair_device);
            this.Controls.Add(this.return_main);
            this.Controls.Add(this.device_list);
            this.Controls.Add(this.device_msg);
            this.Controls.Add(this.discover_device);
            this.Name = "Devices";
            this.Text = "设备连接";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Devices_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button discover_device;
        private System.Windows.Forms.TextBox device_msg;
        private System.Windows.Forms.ListBox device_list;
        private System.Windows.Forms.Button return_main;
        private System.Windows.Forms.Button pair_device;
    }
}