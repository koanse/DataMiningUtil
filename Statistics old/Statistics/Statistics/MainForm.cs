using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPlot;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Statistics
{
    public partial class MainForm : Form
    {
        bool useSturgess = true;
        double alpha = 0.05;
        Sample[] arrSmp = new Sample[0], arrTSmp;
        public MainForm()
        {
            InitializeComponent();
            //arrSmp = new Sample[1];
            //arrTranSmp = new TranSample[1];
            //arrSmp[0] = new Sample("x", "x<SUB>1</SUB>", new double[] { 1, 2, 3, 4 });
            //arrTranSmp[0] = new TranSample(arrSmp[0], "Нет");
            //lvSample.Items.Add(new ListViewItem(new string[] { "x", "Нет" }));

            arrSmp = new Sample[2];
            arrTSmp = new Sample[2];
            arrSmp[0] = new Sample("Признак1", "x<SUB>1</SUB>", new double[] { 1, 2, 3, 4 });
            arrSmp[1] = new Sample("Признак2", "x<SUB>2</SUB>", new double[] { 3, 5, 7, 9 });
            arrTSmp[0] = (Sample)arrSmp[0].Clone();
            arrTSmp[1] = (Sample)arrSmp[1].Clone();
            lvSample.Items.Add(new ListViewItem(new string[] { "Признак1", "x" }));
            lvSample.Items.Add(new ListViewItem(new string[] { "Признак2", "x" }));

            alphaToolStripTextBox.Text = alpha.ToString();
        }
        void ShowSampleInfo()
        {
            int index = lvSample.SelectedIndices[0];
            try
            {
                arrTSmp[index].Calculate();
                arrTSmp[index].DoHistogram(useSturgess);
                wbSample.DocumentText = arrTSmp[index].GetReport();
            }
            catch
            {
                wbSample.DocumentText = "";
            }
            
            chart1.Series[0].Points.Clear();         
            for (int i = 0; i < arrTSmp[index].arrMid.Length; i++)
            {
                chart1.Series[0].Points.AddXY(arrTSmp[index].arrMid[i], arrTSmp[index].arrFreq[i]);
            }
        }        
        void lvSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShowSampleInfo();
            }
            catch { }
        }
        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImportForm imForm = new ImportForm();
                if (imForm.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmp = imForm.GetSamples();
                DataForm daForm = new DataForm(arrSmp);
                if (daForm.ShowDialog() != DialogResult.OK)
                    return;
                this.arrSmp = daForm.arrSmp;
                arrTSmp = new Sample[arrSmp.Length];
                for (int i = 0; i < arrTSmp.Length; i++)
                {
                    arrTSmp[i] = (Sample)arrSmp[i].Clone();
                }
                lvSample.Items.Clear();
                lvSample.SuspendLayout();
                foreach (Sample s in arrSmp)
                    lvSample.Items.Add(new ListViewItem(new string[] { s.name, "x" }));
                lvSample.ResumeLayout();
            }
            catch { }
        }        
        void editFactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvSample.SelectedIndices[0];
                string tr = lvSample.Items[index].SubItems[1].Text;
                FactorForm fForm = new FactorForm(arrSmp[index], tr);
                if (fForm.ShowDialog() != DialogResult.OK)
                    return;
                arrSmp[index] = fForm.smp;
                Sample ts = (fForm.smp.Clone() as Sample);
                ts.Transform(fForm.tr);
                arrTSmp[index] = ts;
                lvSample.Items[index].SubItems[0].Text = arrSmp[index].name;
                lvSample.Items[index].SubItems[1].Text = fForm.tr;
            }
            catch { }
        }
        void removeFactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (arrSmp.Length < 2)
                    return;
                int index = lvSample.SelectedIndices[0];
                Sample[] arrSmpNew = new Sample[arrSmp.Length - 1];
                for (int i = 0; i < index; i++)
                    arrSmpNew[i] = arrSmp[i];
                for (int i = index; i < arrSmpNew.Length; i++)
                    arrSmpNew[i] = arrSmp[i + 1];
                arrSmp = arrSmpNew;

                Sample[] arrTSmpNew = new Sample[arrTSmp.Length - 1];
                for (int i = 0; i < index; i++)
                    arrTSmpNew[i] = arrTSmp[i];
                for (int i = index; i < arrTSmpNew.Length; i++)
                    arrTSmpNew[i] = arrTSmp[i + 1];
                arrTSmp = arrTSmpNew;

                lvSample.Items.RemoveAt(index);
            }
            catch { }
        }
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        void regressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTSmp[i].name;
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTSmp.Length - 1];
                int index = sfFrom.index;
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTSmp[i + 1];
                Regression reg = new Regression(arrTSmp[index], arrSmpX);
                string report = reg.RegReport();
                RepForm rForm = new RepForm("Множественная регрессия", report);
                rForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка построения регрессии");
            }
        }
        void coeffCorrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTSmp[i].name;
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTSmp.Length - 1];
                int index = sfFrom.index;
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTSmp[i + 1];
                Regression reg = new Regression(arrTSmp[index], arrSmpX);
                string rep = reg.GetCorrReport();
                RepForm rForm = new RepForm("Корреляционный анализ", rep);
                rForm.ShowDialog();
            }
            catch { }
        }
        void regHypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTSmp[i].name;
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTSmp.Length - 1];
                int index = sfFrom.index;
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTSmp[i + 1];
                Regression reg = new Regression(arrTSmp[index], arrSmpX);
                string report = reg.CheckReg(alpha);
                RepForm rForm = new RepForm("Проверка значимости уравнения регрессии", report);
                rForm.ShowDialog();
            }
            catch { }
        }
        void corrHypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTSmp[i].name;
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTSmp.Length - 1];
                int index = sfFrom.index;
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTSmp[i + 1];
                Regression reg = new Regression(arrTSmp[index], arrSmpX);
                string report = reg.CheckCorr(alpha);
                RepForm rForm = new RepForm("Проверка значимости коэффициентов корреляции", report);
                rForm.ShowDialog();
            }
            catch { }
        }
        void normDistHypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTSmp[i].name;
                SelFactorForm sfFrom = new SelFactorForm(arrName,
                    "Выберете исследуемый признак");
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                int index = sfFrom.index;
                RepForm rForm = new RepForm("Проверка нормальности выборочного закона распределения",
                    arrSmp[index].CheckNorm(alpha));
                rForm.ShowDialog();
            }
            catch { }
        }
        void doIdentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTSmp[i].name;
                SelFactorForm sFormY = new SelFactorForm(arrName, null);
                if (sFormY.ShowDialog() != DialogResult.OK)
                    return;
                SelFactorForm sFormX = new SelFactorForm(arrName,
                    "Выберете влияющий признак");
                if (sFormX.ShowDialog() != DialogResult.OK)
                    return;
                int indexX = sFormX.index, indexY = sFormY.index;
                IdentForm iForm = new IdentForm(arrSmp[indexX],
                    arrSmp[indexY]);
                if (iForm.ShowDialog() != DialogResult.OK)
                    return;
                arrTSmp[indexX] = (Sample)arrSmp[indexX].Clone();
                arrTSmp[indexX].Transform(iForm.transform);
                lvSample.Items[indexX].SubItems[1].Text = iForm.transform;
            }
            catch { }
        }
        void alphaToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                alpha = double.Parse(alphaToolStripTextBox.Text);
            }
            catch
            {
                alpha = 0.05;
                alphaToolStripTextBox.Text = alpha.ToString();
            }
        }
        void sturgessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sturgessToolStripMenuItem.Checked)
            {
                useSturgess = false;
                sturgessToolStripMenuItem.Checked = false;
            }
            else
            {
                useSturgess = true;
                sturgessToolStripMenuItem.Checked = true;
            }
        }
        void aboutBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Кондауров А.С.");
        }
        void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, arrSmp);
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
        void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                arrSmp = (Sample[])bf.Deserialize(fs);
                fs.Close();
                arrTSmp = new Sample[arrSmp.Length];
                for (int i = 0; i < arrTSmp.Length; i++)
                {
                    arrTSmp[i] = (Sample)arrSmp[i].Clone();
                    arrTSmp[i].Transform("x");
                }

                lvSample.Items.Clear();
                lvSample.SuspendLayout();
                foreach (Sample s in arrSmp)
                    lvSample.Items.Add(new ListViewItem(new string[] { s.name, "x" }));
                lvSample.ResumeLayout();
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки");
            }
        }
        void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void normToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sample[] arrSNew = new Sample[arrSmp.Length], arrTSNew = new Sample[arrTSmp.Length];
            try
            {
                for (int i = 0; i < arrSmp.Length; i++)
                {
                    arrSNew[i] = (Sample)arrSmp[i].Clone();
                    arrSNew[i].Norm();
                    arrTSNew[i] = (Sample)arrTSmp[i].Clone();
                    arrTSNew[i].Norm();
                }
                arrSmp = arrSNew;
                arrTSmp = arrTSNew;
            }
            catch { }
        }      
    }
}