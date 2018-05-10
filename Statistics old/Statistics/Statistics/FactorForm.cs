using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class FactorForm : Form
    {
        public Sample smp;
        public string tr;
        public FactorForm(Sample smp, string transform)
        {
            InitializeComponent();
            this.smp = (Sample)smp.Clone();
            tbName.Text = smp.name;
            cbTran.Text = transform;
            tbN.Text = smp.arr.Length.ToString();
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            tr = cbTran.Text;
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