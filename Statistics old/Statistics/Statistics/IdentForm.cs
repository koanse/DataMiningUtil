using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPlot;

namespace Statistics
{
    public partial class IdentForm : Form
    {
        Sample smpY, smpX;
        Regression[] arrReg;
        string[] arrTranName;
        Sample[] arrTSmp;
        public string transform;
        public IdentForm(Sample smpX, Sample smpY)
        {
            InitializeComponent();
            this.smpY = smpY;
            this.smpX = smpX;
            arrTranName = new string[] { "x", "x^2", "x^3", "1/x",
                "1/x^2", "sqrt(x)", "1/sqrt(x)", "ln(x)", "exp(x)" };
            List<string> lTName = new List<string>();
            List<Regression> lReg = new List<Regression>();
            List<Sample> lTSmp = new List<Sample>();
            for (int i = 0; i < arrTranName.Length; i++)
            {
                Sample ts;
                try
                {
                    ts = (Sample)smpX.Clone();
                    ts.Transform(arrTranName[i]);
                }
                catch
                {
                    continue;
                }
                lTName.Add(arrTranName[i]);
                lTSmp.Add(ts);
                Regression r = new Regression(smpY, new Sample[] { ts });
                lReg.Add(r);
                lbTran.Items.Add(string.Format("{0} [r = {1:g3}]",
                    arrTranName[i], r.GetRyx1()));
            }
            arrTranName = lTName.ToArray();
            arrTSmp = lTSmp.ToArray();
            arrReg = lReg.ToArray();
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                transform = arrTranName[lbTran.SelectedIndex];
            }
            catch
            {
                transform = "x";
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        void lbTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lbTran.SelectedIndex;
                Sample ts = arrTSmp[index];
                Regression reg = arrReg[index];
                ch.SuspendLayout();
                ch.Series[0].Points.Clear(); ch.Series[1].Points.Clear();
                double[] arrX = (double[])smpX.arr.Clone(), arrY = (double[])smpY.arr.Clone();
                double min = double.MaxValue, max = double.MinValue;
                for (int i = 0; i < arrX.Length; i++)
                {
                    if (arrX[i] < min)
                        min = arrX[i];
                    if (arrX[i] > max)
                        max = arrX[i];
                }
                for (int i = 0; i < 100; i++)
                {
                    double x = min + (max - min) / 100 * i;
                    Sample sTmp = new Sample(new double[] { x });
                    sTmp.Transform(arrTranName[index]);
                    double y = reg.RegValue(new double[] { sTmp[0]});
                    ch.Series[1].Points.AddXY(x, y);
                }
                for (int i = 0; i < arrX.Length; i++)
                {
                    ch.Series[0].Points.AddXY(arrX[i], arrY[i]);
                }
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