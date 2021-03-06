﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaYang
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 1;
            this.comboBox3.SelectedIndex = 0;
        }

        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                Application.DoEvents();//可执行某无聊的操作
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.Owner;
            main.button2.BackColor = Color.Green;
            main.serialPort1.Write("$MUSIC:STOP\r\n");
            if (main.label2.Text.Length > 10 && main.label3.Text == "YES")
            {
                main.UpdataSQL(main.label2.Text, "Music", "pass");
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.Owner;
            main.button2.BackColor = Color.Red;
            main.serialPort1.Write("$MUSIC:STOP\r\n");
            if (main.label2.Text.Length > 10 && main.label3.Text == "YES")
            {
                main.UpdataSQL(main.label2.Text, "Music", "fail");
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length == 1 && comboBox3.Text.Length == 1 && comboBox2.Text.Length == 1)
            {
                Main main = (Main)this.Owner;
                switch (int.Parse(comboBox3.Text))
                {
                    case 1:
                        main.serialPort1.Write("$MUSIC:VOLUME,1\r\n");
                        break;
                    case 2:
                        main.serialPort1.Write("$MUSIC:VOLUME,2\r\n");
                        break;
                    case 3:
                        main.serialPort1.Write("$MUSIC:VOLUME,3\r\n");
                        break;
                    case 4:
                        main.serialPort1.Write("$MUSIC:VOLUME,4\r\n");
                        break;
                    case 5:
                        main.serialPort1.Write("$MUSIC:VOLUME,5\r\n");
                        break;
                    default:
                        break;
                }
                switch (int.Parse(comboBox1.Text))
                {
                    case 0:
                        main.serialPort1.Write("$MUSIC:TIMBRE,0\r\n");
                        break;
                    case 1:
                        main.serialPort1.Write("$MUSIC:TIMBRE,1\r\n");
                        break;
                    case 2:
                        main.serialPort1.Write("$MUSIC:TIMBRE,2\r\n");
                        break;
                    default:
                        break;
                }
                switch (int.Parse(comboBox2.Text))
                {
                    case 0:
                        main.serialPort1.Write("$MUSIC:START,0\r\n");
                        break;
                    case 1:
                        main.serialPort1.Write("$MUSIC:START,1\r\n");
                        break;
                    case 2:
                        main.serialPort1.Write("$MUSIC:START,2\r\n");
                        break;
                    case 3:
                        main.serialPort1.Write("$MUSIC:START,3\r\n");
                        break;
                    case 4:
                        main.serialPort1.Write("$MUSIC:START,4\r\n");
                        break;
                    case 5:
                        main.serialPort1.Write("$MUSIC:START,5\r\n");
                        break;
                    case 6:
                        main.serialPort1.Write("$MUSIC:START,6\r\n");
                        break;
                    case 7:
                        main.serialPort1.Write("$MUSIC:START,7\r\n");
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("请选择相应的音效","提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (comboBox1.Text.Length == 1 && comboBox3.Text.Length == 1)
            {
                Main main = (Main)this.Owner;
                switch (int.Parse(comboBox3.Text))
                {
                    case 1:
                        main.serialPort1.Write("$MUSIC:VOLUME,1\r\n");
                        break;
                    case 2:
                        main.serialPort1.Write("$MUSIC:VOLUME,2\r\n");
                        break;
                    case 3:
                        main.serialPort1.Write("$MUSIC:VOLUME,3\r\n");
                        break;
                    case 4:
                        main.serialPort1.Write("$MUSIC:VOLUME,4\r\n");
                        break;
                    case 5:
                        main.serialPort1.Write("$MUSIC:VOLUME,5\r\n");
                        break;
                    default:
                        break;
                }
                switch (int.Parse(comboBox1.Text))
                {
                    case 0:
                        main.serialPort1.Write("$MUSIC:TIMBRE,0\r\n");
                        break;
                    case 1:
                        main.serialPort1.Write("$MUSIC:TIMBRE,1\r\n");
                        break;
                    case 2:
                        main.serialPort1.Write("$MUSIC:TIMBRE,2\r\n");
                        break;
                    default:
                        break;
                }
                main.serialPort1.Write("$MUSIC:START,0\r\n");
                Delay(2000);
                main.serialPort1.Write("$MUSIC:START,1\r\n");
                Delay(2500);
                main.serialPort1.Write("$MUSIC:START,2\r\n");
                Delay(2500);
                main.serialPort1.Write("$MUSIC:START,3\r\n");
                Delay(2000);
                main.serialPort1.Write("$MUSIC:START,4\r\n");
                Delay(2000);
                main.serialPort1.Write("$MUSIC:START,5\r\n");
                Delay(2000);
                main.serialPort1.Write("$MUSIC:START,6\r\n");
                Delay(2000);
                main.serialPort1.Write("$MUSIC:START,7\r\n");
            }
            button2.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
    }
}
