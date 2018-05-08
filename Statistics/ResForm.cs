using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class ResForm : Form
    {
        public ResForm(string title, string text)
        {
            InitializeComponent();
            Text = title;
            webBrowser1.DocumentText = text;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
