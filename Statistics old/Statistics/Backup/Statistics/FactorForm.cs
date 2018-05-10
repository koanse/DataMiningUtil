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
        Sample smp;
        TranSample ts;
        public FactorForm(Sample smp, string transform)
        {
            InitializeComponent();
            this.smp = (Sample)smp.Clone();
            tbName.Text = smp.GetName();
            cbTran.Text = transform;
            tbN.Text = smp.GetLength().ToString();
        }
        public Sample GetSample()
        {
            return smp;
        }
        public TranSample GetTranSample()
        {
            return ts;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                smp.SetName(tbName.Text);
                ts = new TranSample(smp, cbTran.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch { }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }        
    }
}