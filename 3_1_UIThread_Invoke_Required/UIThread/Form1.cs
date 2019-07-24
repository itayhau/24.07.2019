using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            if (label1.InvokeRequired)
            {
                Action a = () => { label1.Text = DateTime.Now.Millisecond.ToString(); };
                label1.BeginInvoke(a);
            }
            else
            {
                label1.Text = DateTime.Now.Millisecond.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //label1.Text = DateTime.Now.Millisecond.ToString();
                UpdateLabel();
            });
        }
    }
}
