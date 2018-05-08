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
    public partial class RegForm : Form
    {
        Sample sY;
        Sample[] arrS, arrTS, arrSXY;
        public List<Sample> lS = new List<Sample>();
        SortedDictionary<double, Sample>[] arrD;
        public RegForm(Sample sY, Sample[] arrS,
            SortedDictionary<double,Sample>[] arrD, SortedDictionary<double,Sample> dic,
            List<Sample> lS)
        {
            InitializeComponent();
            this.arrD = arrD;
            this.arrS = arrS;
            this.sY = sY;
            lRes.Text += sY.name;
            foreach (Sample s in arrS)
            {
                cb.Items.Add(s.name);
            }
            double[] arrR = dic.Keys.ToArray();            
            arrSXY = dic.Values.ToArray();
            for (int i = 0; i < arrR.Length; i++)
            {
                lbXY.Items.Add(string.Format("{0}, |r| = {1:g3}", arrSXY[i].name, arrR[i]));
            }
            if (lS == null)
                return;
            foreach (Sample s in lS)
            {
                this.lS.Add((Sample)s.Clone());
                lbS.Items.Add(s.name);
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = cb.SelectedIndex;
                double[] arrR = arrD[index].Keys.ToArray();
                arrTS = arrD[index].Values.ToArray();
                lbX.Items.Clear();
                for (int i = 0; i < arrR.Length; i++)
                {
                    lbX.Items.Add(string.Format("{0}, |r| = {1:g3}", arrTS[i].name, arrR[i]));
                }
            }
            catch { }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbX.SelectedIndex;
                lS.Add(arrTS[index]);
                lbS.Items.Add(lbX.SelectedItem);
            }
            catch { }
        }

        private void btnXY_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbXY.SelectedIndex;
                lS.Add(arrSXY[index]);
                lbS.Items.Add(lbXY.SelectedItem);
            }
            catch { }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbS.SelectedIndex;
                lS.RemoveAt(index);
                lbS.Items.RemoveAt(index);
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnExpr_Click(object sender, EventArgs e)
        {
            Sample ts;
            try
            {
                ts = Sample.Transform(arrS, tb.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
                return;
            }
            Regression reg = new Regression(sY, new Sample[] { ts });
            lS.Add(ts);
            lbS.Items.Add(string.Format("{0}, |r| = {1:g3}", ts.name, Math.Abs(reg.Ryx1())));
        }
    }
}
