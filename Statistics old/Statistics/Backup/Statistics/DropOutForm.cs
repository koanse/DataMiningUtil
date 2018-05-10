using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class DropOutForm : Form
    {
        bool useStud;
        double alpha = 0.05;
        public DropOutForm(bool useStud)
        {
            InitializeComponent();
            this.useStud = useStud;
            if (useStud)
            {
                rbStud.Checked = true;
                rbStud.Text += " (рекомендовано)";
            }
            else
            {
                rbTau.Checked = true;
                rbTau.Text += " (рекомендовано)";
            }
            tbAlpha.Text = alpha.ToString();
        }
        public bool UseStudent()
        {
            return useStud;
        }
        public double GetAlpha()
        {
            return alpha;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbStud.Checked)
                    useStud = true;
                else
                    useStud = false;
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