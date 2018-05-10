using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class AlphaForm : Form
    {
        double alpha = 0.05;
        public AlphaForm()
        {
            InitializeComponent();
            tbAlpha.Text = alpha.ToString();
        }
        public double GetAlpha()
        {
            return alpha;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                alpha = double.Parse(tbAlpha.Text);
                if (alpha >= 1 || alpha <= 0)
                    throw new Exception();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Неверный уровень значимости");
            }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}