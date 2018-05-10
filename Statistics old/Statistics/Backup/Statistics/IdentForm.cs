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
        TranSample[] arrTranSmp;
        string transform;
        public IdentForm(Sample smpX, Sample smpY)
        {
            InitializeComponent();
            this.smpY = smpY;
            this.smpX = smpX;
            arrTranName = new string[] { "Нет", "Квадрат", "Куб", "Обратное",
                "Обратное в квадрате", "Квадратный корень", "Единица на квадратный корень",
                "Натуральный логарифм", "Экспонента" };
            arrTranSmp = new TranSample[arrTranName.Length];
            arrReg = new Regression[arrTranName.Length];            
            for (int i = 0; i < arrTranName.Length; i++)
            {
                TranSample ts = new TranSample(smpX, arrTranName[i]);
                arrTranSmp[i] = ts;
                arrReg[i] = new Regression(smpY, new Sample[] { ts });
                string transform = arrTranSmp[i].GetTransform();
                if (transform == "Нет")
                    transform = "Линейное";
                lbTran.Items.Add(string.Format("{0} [R = {1}]",
                    transform, Math.Round(arrReg[i].GetR_yx1(), 3)));
            }
        }
        public string GetTransform()
        {
            return transform;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                transform = arrTranName[lbTran.SelectedIndex];
            }
            catch
            {
                transform = "Нет";
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        void lbTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lbTran.SelectedIndex;
                TranSample ts = arrTranSmp[index];
                Regression reg = arrReg[index];
                ps.Clear();
                LinePlot lp = new LinePlot();
                lp.AbscissaData = ts.CloneArray();
                lp.OrdinateData = reg.CloneArray();
                ps.Add(lp);
                PointPlot pp = new PointPlot();
                pp.AbscissaData = ts.CloneArray();
                pp.OrdinateData = smpY.CloneArray();
                ps.Add(pp);
                ps.XAxis1.Label = string.Format("{0} [{1}]", smpX.GetName(), arrTranName[index]);
                ps.YAxis1.Label = smpY.GetName();
                ps.Refresh();                
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