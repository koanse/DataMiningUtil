using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Statistics
{
    public partial class MainForm : Form
    {
        Sample[] arrS;
        List<Sample>[] arrStruct;
        public MainForm()
        {
            InitializeComponent();
        }

        private void openExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            SheetForm sf = new SheetForm(Sample.ExcelSheets(openFileDialog1.FileName));
            if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            string sheet = sf.lb.SelectedItem.ToString();
            ColumnForm cf = new ColumnForm(Sample.ExcelColumns(openFileDialog1.FileName, sheet));
            if (cf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            List<string> lS = new List<string>();
            for (int i = 0; i < cf.clb.CheckedItems.Count; i++)
			{
                lS.Add(cf.clb.CheckedItems[i].ToString());			 
			}
            arrS = Sample.FromExcel(openFileDialog1.FileName, sheet, lS.ToArray(), "x");
            arrStruct = new List<Sample>[arrS.Length];
            lb.Items.Clear();
            foreach (Sample s in arrS)
            {
                lb.Items.Add(s.name);
            } 
            DataForm df = new DataForm(arrS);
            df.ShowDialog();
        }

        private void btnCheckNorm_Click(object sender, EventArgs e)
        {
            int i = lb.SelectedIndex;
            AlphaForm af = new AlphaForm();
            if (af.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            double alpha = double.Parse(af.tb.Text);
            double[] arrPNorm;
            string rep = arrS[i].CheckNorm(alpha, out arrPNorm);
            ResForm rf = new ResForm("Проверка нормальности", rep);
            rf.ShowDialog();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            int i = lb.SelectedIndex;
            AlphaForm af = new AlphaForm();
            if (af.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            double alpha = double.Parse(af.tb.Text);                        
            string rep;
            int[] arrI = arrS[i].DropoutErrors(alpha, out rep);
            ResForm rf = new ResForm("Отсев аномальных наблюдений", rep);
            rf.ShowDialog();
            if (MessageBox.Show("Отсеять аномальные наблюдения?", "Подтвердите отсев наблюдений", MessageBoxButtons.YesNo) !=
                System.Windows.Forms.DialogResult.Yes)
                return;
            foreach (Sample s in arrS)
            {
                s.RemoveValues(arrI);
            }
            DataForm df = new DataForm(arrS);
            df.ShowDialog();
        }

        private void btnCorr_Click(object sender, EventArgs e)
        {
            List<Sample> lS = new List<Sample>(arrS);
            lS.RemoveAt(0);
            Regression reg = new Regression(arrS[0], lS.ToArray());
            string rep = reg.CorrReport();
            ResForm rf = new ResForm("Корреляционный анализ", rep);
            rf.ShowDialog();
        }

        private void btnCheckCorr_Click(object sender, EventArgs e)
        {
            List<Sample> lS = new List<Sample>(arrS);
            lS.RemoveAt(0);
            Regression reg = new Regression(arrS[0], lS.ToArray());
            AlphaForm af = new AlphaForm();
            if (af.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            double alpha = double.Parse(af.tb.Text);                        
            string rep = reg.CheckCorr(alpha);
            ResForm rf = new ResForm("Проверка значимости коэффициентов корреляции", rep);
            rf.ShowDialog();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            int index = lb.SelectedIndex;
            List<Sample> lS = new List<Sample>(arrS);
            lS.RemoveAt(index);
            SortedDictionary<double,Sample>[] arrD = new SortedDictionary<double,Sample>[lS.Count];
            for (int i = 0; i < lS.Count; i++)
			{
                arrD[i] = Regression.TranSamples(lS[i], arrS[index]);                			 
			}
            ProgressForm pf = new ProgressForm();
            pf.Show();
            SortedDictionary<double,Sample> dic = Regression.TranSamples(lS.ToArray(), arrS[index],
                pf, new Regression.ProgressDelegate(pf.ProgressMethod));
            pf.Close();
            RegForm regf = new RegForm(arrS[index], lS.ToArray(), arrD, dic, arrStruct[index]);
            if (regf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            arrStruct[index] = regf.lS;
            Regression reg = new Regression(arrS[index], arrStruct[index].ToArray());
            ResForm rf = new ResForm("Множественная регрессия", reg.RegReport());
            rf.ShowDialog();
        }

        private void btnCheckReg_Click(object sender, EventArgs e)
        {
            int index = lb.SelectedIndex;
            AlphaForm af = new AlphaForm();
            if (af.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            double alpha = double.Parse(af.tb.Text);                        
            Regression reg = new Regression(arrS[index], arrStruct[index].ToArray());
            ResForm rf = new ResForm("Проверка значимости уравнения множественной регрессии", reg.CheckReg(alpha));
            rf.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()!=DialogResult.OK)
                return;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream     fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);        
            bf.Serialize(fs, arrS);
            bf.Serialize(fs, arrStruct);
            fs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            arrS = (Sample[])bf.Deserialize(fs);
            arrStruct = (List<Sample>[])bf.Deserialize(fs);
            fs.Close();
            lb.Items.Clear();
            foreach (Sample s in arrS)
            {
                lb.Items.Add(s.name);
            }            
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lb.SelectedIndex;
                arrS[index].DoHistogram();
                wb.DocumentText = arrS[index].Report();
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < arrS[index].arrMid.Length; i++)
                {
                    chart1.Series[0].Points.AddXY(arrS[index].arrMid[i], arrS[index].arrP[i]);
                }
            }
            catch { }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int i = lb.SelectedIndex;
            lb.Items.RemoveAt(i);
            List<Sample> lS = new List<Sample>(arrS);
            lS.RemoveAt(i);
            arrS = lS.ToArray();
            List<List<Sample>> lStruct = new List<List<Sample>>(arrStruct);
            lStruct.RemoveAt(i);
            arrStruct = lStruct.ToArray();
        }

        private void btnNorm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrS.Length; i++)
            {
                arrS[i].Norm();
                arrStruct[i] = null;
            }
            MessageBox.Show("Нормировка выполнена");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataForm df = new DataForm(arrS);
            df.ShowDialog();
        }
    }
}
