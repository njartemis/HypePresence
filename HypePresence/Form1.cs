using RPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypePresence
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
            {
                MessageBox.Show("Put a valid information!", "ERROR");
                richTextBox1.Text = "[ERROR] ClientID is not provided";
            }
            else
            {
                richTextBox1.Text = "[LOGS] RichPresence has been launched on : " + DateTime.Now;
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(textBox1.Text, ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(textBox1.Text, ref this.handlers, true, null);
                this.presence.details = textBox3.Text;
                this.presence.state = textBox2.Text;
                this.presence.largeImageKey = textBox4.Text;
                this.presence.smallImageKey = textBox5.Text;
                this.presence.largeImageText = textBox6.Text;
                DiscordRpc.UpdatePresence(ref this.presence);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DiscordRpc.Shutdown();
            MessageBox.Show("RichPresence has been stopped", "HypePresence");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
                textBox1.PasswordChar = '●';
                checkBox1.Text = "Show";
            }
            else
            {
                textBox1.PasswordChar = '\0';
                textBox1.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HypePresence\nDeveloped by Robertas64", "Information");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
            {
                MessageBox.Show("Put a valid informations!");
                richTextBox1.Text = "[ERROR] Failed to shutdown, reason : No valid information";
            }
            else
            {
                DiscordRpc.Shutdown();
                richTextBox1.Text = "[LOGS] RichPresence has been disconnected!";
                MessageBox.Show("RichPresence is disconnected");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
                textBox1.PasswordChar = '●';
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
                textBox1.PasswordChar = '\0';
            }
        }
    }
}
