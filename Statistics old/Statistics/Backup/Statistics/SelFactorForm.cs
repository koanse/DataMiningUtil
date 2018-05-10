using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class SelFactorForm : Form
    {
        public SelFactorForm(string[] arrName, string text)
        {
            InitializeComponent();
            foreach (string s in arrName)
                lbFactor.Items.Add(s);
            if (text != null)
                label1.Text = text;
        }
        public int GetIndex()
        {
            return lbFactor.SelectedIndex;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            if (lbFactor.SelectedIndex == -1)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}