namespace 远程设备存活检测工具
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddDevice = new System.Windows.Forms.Button();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.Delete_1 = new System.Windows.Forms.Button();
            this.Change_1 = new System.Windows.Forms.Button();
            this.Enter_1 = new System.Windows.Forms.Button();
            this.IP_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ShowMessage = new System.Windows.Forms.CheckBox();
            this.RetryCount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GetTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Log = new System.Windows.Forms.ListBox();
            this.ICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设备";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.AddDevice);
            this.flowLayoutPanel1.Controls.Add(this.panel_1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(844, 418);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddDevice
            // 
            this.AddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDevice.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddDevice.Location = new System.Drawing.Point(3, 3);
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(200, 100);
            this.AddDevice.TabIndex = 0;
            this.AddDevice.Text = "添加设备";
            this.AddDevice.UseVisualStyleBackColor = true;
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.Gray;
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.Delete_1);
            this.panel_1.Controls.Add(this.Change_1);
            this.panel_1.Controls.Add(this.Enter_1);
            this.panel_1.Controls.Add(this.IP_1);
            this.panel_1.Controls.Add(this.label1);
            this.panel_1.Location = new System.Drawing.Point(209, 3);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(200, 100);
            this.panel_1.TabIndex = 1;
            // 
            // Delete_1
            // 
            this.Delete_1.BackColor = System.Drawing.Color.Transparent;
            this.Delete_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_1.Location = new System.Drawing.Point(130, 65);
            this.Delete_1.Name = "Delete_1";
            this.Delete_1.Size = new System.Drawing.Size(58, 23);
            this.Delete_1.TabIndex = 4;
            this.Delete_1.Text = "删除";
            this.Delete_1.UseVisualStyleBackColor = false;
            // 
            // Change_1
            // 
            this.Change_1.BackColor = System.Drawing.Color.Transparent;
            this.Change_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_1.Location = new System.Drawing.Point(68, 65);
            this.Change_1.Name = "Change_1";
            this.Change_1.Size = new System.Drawing.Size(58, 23);
            this.Change_1.TabIndex = 3;
            this.Change_1.Text = "更改";
            this.Change_1.UseVisualStyleBackColor = false;
            // 
            // Enter_1
            // 
            this.Enter_1.BackColor = System.Drawing.Color.Transparent;
            this.Enter_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_1.Location = new System.Drawing.Point(6, 65);
            this.Enter_1.Name = "Enter_1";
            this.Enter_1.Size = new System.Drawing.Size(58, 23);
            this.Enter_1.TabIndex = 2;
            this.Enter_1.Text = "确定";
            this.Enter_1.UseVisualStyleBackColor = false;
            // 
            // IP_1
            // 
            this.IP_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IP_1.Location = new System.Drawing.Point(6, 33);
            this.IP_1.MaxLength = 100;
            this.IP_1.Name = "IP_1";
            this.IP_1.Size = new System.Drawing.Size(182, 21);
            this.IP_1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备IP：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ShowMessage);
            this.tabPage2.Controls.Add(this.RetryCount);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.GetTime);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShowMessage
            // 
            this.ShowMessage.AutoSize = true;
            this.ShowMessage.Checked = true;
            this.ShowMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMessage.Location = new System.Drawing.Point(10, 79);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(117, 16);
            this.ShowMessage.TabIndex = 8;
            this.ShowMessage.Text = "启用系统消息提示";
            this.ShowMessage.UseVisualStyleBackColor = true;
            // 
            // RetryCount
            // 
            this.RetryCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RetryCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetryCount.FormattingEnabled = true;
            this.RetryCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RetryCount.Location = new System.Drawing.Point(90, 42);
            this.RetryCount.Name = "RetryCount";
            this.RetryCount.Size = new System.Drawing.Size(52, 20);
            this.RetryCount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "尝试通信次数：";
            // 
            // GetTime
            // 
            this.GetTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetTime.FormattingEnabled = true;
            this.GetTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.GetTime.Location = new System.Drawing.Point(90, 9);
            this.GetTime.Name = "GetTime";
            this.GetTime.Size = new System.Drawing.Size(52, 20);
            this.GetTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "状态获取间隔：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Log);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(850, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "日志";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 12;
            this.Log.Location = new System.Drawing.Point(3, 3);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(844, 418);
            this.Log.TabIndex = 0;
            // 
            // ICON
            // 
            this.ICON.ContextMenuStrip = this.contextMenuStrip1;
            this.ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("ICON.Icon")));
            this.ICON.Text = "远程设备存活检测工具";
            this.ICON.Visible = true;
            this.ICON.DoubleClick += new System.EventHandler(this.ICON_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "远程设备存活检测工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddDevice;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_1;
        private System.Windows.Forms.Button Delete_1;
        private System.Windows.Forms.Button Change_1;
        private System.Windows.Forms.Button Enter_1;
        private System.Windows.Forms.ComboBox GetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.CheckBox ShowMessage;
        private System.Windows.Forms.ComboBox RetryCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon ICON;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

