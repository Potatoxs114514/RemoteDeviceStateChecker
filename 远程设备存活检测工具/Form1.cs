using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 远程设备存活检测工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);
        private string strFilePath = "DeviceCard.ini";//获取INI文件路径
        private string strSec = "Device"; //类名

        private string ContentValue(string Section, string key)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(Section, key, "", temp, 1024, strFilePath);
            return temp.ToString();
        }

        int deviceCount = 0;
        ArrayList panelList = new ArrayList();
        private void AddDevice_Click(object sender, EventArgs e)
        {
            AddDeviceCard();
            deviceCount++;
        }

        private void AddDeviceCard()
        {
            //初始化变量
            int retryCount = int.Parse(RetryCount.Text);
            string ip = "";
            string port = "";
            bool deviceState = false;
            //初始化控件
            Panel panel = new Panel();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();
            //添加计时器
            Thread thread;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = int.Parse(GetTime.Text) * 1000;
            timer.Tick += (s,e) => 
            {
                timer.Interval = int.Parse(GetTime.Text) * 1000;
                //deviceState = GetDeviceState(ip,port);
                thread = new Thread(() => deviceState = GetDeviceState(ip, port));
                try
                {
                    thread.Start();
                }
                catch { }
                if (deviceState)
                {
                    retryCount = int.Parse(RetryCount.Text);
                    panel.BackColor = Color.LimeGreen;
                }
                else
                {
                    retryCount--;
                    if (retryCount == 0 && ShowMessage.Checked)
                    {
                        ICON.ShowBalloonTip(1000, "提示", "设备(" + textBox.Text + ")已离线", ToolTipIcon.Info);
                    }
                    panel.BackColor = Color.Gray;
                }
            };
            //添加背景
            panel.Size = new Size(200, 100);
            panel.BackColor = Color.Gray;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Visible = true;
            flowLayoutPanel1.Controls.Add(panel);
            //添加文字
            label.Text = "设备IP：";
            label.AutoSize = true;
            label.Location = new Point(5, 12);
            panel.Controls.Add(label);
            //添加输入框
            textBox.Size = new Size(182, 21);
            textBox.Location = new Point(6, 33);
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.MaxLength = 100;
            panel.Controls.Add(textBox);
            //添加确定按钮
            button1.Location = new Point(6, 65);
            button1.Size = new Size(58, 23);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Text = "确定";
            button1.Click += (s, e) => 
            {
                textBox.Text = textBox.Text.Replace("：", ":");
                textBox.ReadOnly = true;
                button1.Enabled = false;
                button2.Enabled = true;
                if (textBox.Text.IndexOf(":") == -1)
                {
                    ip = textBox.Text;
                    port = "3389";
                }
                else
                {
                    ip = textBox.Text.Remove(textBox.Text.IndexOf(":"));
                    port = textBox.Text.Substring(textBox.Text.IndexOf(":") + 1);
                }
                timer.Start();
            };
            panel.Controls.Add(button1);
            //添加更改按钮
            button2.Location = new Point(68, 65);
            button2.Size = button1.Size;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Text = "更改";
            button2.Enabled = false;
            button2.Click += (s, e) =>
            {
                textBox.ReadOnly = false;
                button1.Enabled = true;
                button2.Enabled = false;
                panel.BackColor = Color.Gray;
                timer.Stop();
            };
            panel.Controls.Add(button2);
            //添加删除按钮
            button3.Location = new Point(130, 65);
            button3.Size = button1.Size;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Text = "删除";
            button3.Click += (s, e) =>
            {
                timer.Enabled = false;
                timer.Dispose();
                flowLayoutPanel1.Controls.Remove(panel);
                AddLog("删除设备(" + textBox.Text + ")");
            };
            panel.Controls.Add(button3);
            AddLog("添加设备");
        }

        private string GetIP(string domain)
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry(domain);
            IPAddress ip = iPHostEntry.AddressList[0];
            return ip.ToString();
        }

        private bool GetDeviceState(string deviceIP,string port = "3389")
        {
            IPAddress ip;
            try
            {
                ip = IPAddress.Parse(deviceIP);
            }
            catch {
                deviceIP = GetIP(deviceIP);
                ip = IPAddress.Parse(deviceIP);
            }
            IPEndPoint iPEndPoint = new IPEndPoint(ip, int.Parse(port));
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {

                clientSocket.Connect(iPEndPoint);
                clientSocket.Close();
                clientSocket.Dispose();
                AddLog("设备通信成功(" + iPEndPoint + ")");
                return true;
            }
            catch
            {
                AddLog("设备通信失败(" + iPEndPoint + ")");
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddLog("启动软件");
            CheckForIllegalCrossThreadCalls = false;
            Init();
        }

        private void Init()
        {
            AddLog("初始化界面");
            panel_1.Hide();
            GetTime.SelectedIndex = 2;
            RetryCount.SelectedIndex = 2;
        }

        private void AddLog(string text)
        {
            Log.Items.Add("[" + DateTime.Now + "] " + text);
            if (Log.Items.Count > 300)
                    Log.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ICON_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ICON.Visible = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
