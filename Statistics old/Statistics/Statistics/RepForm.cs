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
    public partial class RepForm : Form
    {
        public RepForm(string header, string text)
        {
            InitializeComponent();
            Text = header;
            webBrowser1.DocumentText = text;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
        void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter w = new StreamWriter(fs, Encoding.Default);
                w.WriteLine(webBrowser1.DocumentText);
                w.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла");
            }
        }
    }
}