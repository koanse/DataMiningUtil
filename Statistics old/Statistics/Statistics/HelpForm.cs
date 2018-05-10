using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Statistics
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            StreamWriter sw = new StreamWriter("help.tmp");
            sw.Write(Properties.Resources.help);
            sw.Close();
            rtb.LoadFile("help.tmp");
            File.Delete("help.tmp");
        }
    }
}