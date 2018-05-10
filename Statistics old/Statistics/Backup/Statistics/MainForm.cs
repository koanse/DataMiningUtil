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
        Sample[] arrSmp = new Sample[0], arrTranSmp;
        public MainForm()
        {
            InitializeComponent();
            //arrSmp = new Sample[1];
            //arrTranSmp = new TranSample[1];
            //arrSmp[0] = new Sample("x", "x<SUB>1</SUB>", new double[] { 1, 2, 3, 4 });
            //arrTranSmp[0] = new TranSample(arrSmp[0], "Нет");
            //lvSample.Items.Add(new ListViewItem(new string[] { "x", "Нет" }));

            arrSmp = new Sample[2];
            arrTranSmp = new TranSample[2];
            arrSmp[0] = new Sample("x", "x<SUB>1</SUB>", new double[] { 1, 2, 3, 4 });
            arrSmp[1] = new Sample("y", "x<SUB>2</SUB>", new double[] { 3, 5, 7, 9 });
            arrTranSmp[0] = new TranSample(arrSmp[0], "Нет");
            arrTranSmp[1] = new TranSample(arrSmp[1], "Нет");
            lvSample.Items.Add(new ListViewItem(new string[] { "x", "Нет" }));
            lvSample.Items.Add(new ListViewItem(new string[] { "y", "Нет" }));

            alphaToolStripTextBox.Text = alpha.ToString();
        }
        void ShowSampleInfo()
        {
            int index = lvSample.SelectedIndices[0];
            try
            {
                wbSample.DocumentText = arrTranSmp[index].GetReport();
            }
            catch
            {
                wbSample.DocumentText = "";
            }

            psHist.Clear();
            HistogramPlot hp = new HistogramPlot();
            arrSmp[index].DoHistogram(useSturgess);
            hp.AbscissaData = arrTranSmp[index].CloneHistX();
            hp.OrdinateData = arrTranSmp[index].CloneHistY();
            hp.Pen = Pens.DarkBlue;
            hp.Filled = true;
            hp.RectangleBrush = new RectangleBrushes.HorizontalCenterFade(Color.Lavender, Color.Gold);
            psHist.Add(hp);

            psHist.XAxis1.Label = "Значения признака";
            psHist.YAxis1.Label = "Частота";
            psHist.Title = string.Format("Признак {0}, преобразование: {2}",
                arrTranSmp[index].GetName(), arrTranSmp[index].GetMark(),
                ((TranSample)arrTranSmp[index]).GetTransform());
            psHist.Invalidate();
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
                this.arrSmp = daForm.GetSamples();
                foreach (Sample s in arrSmp)
                    s.DoHistogram(useSturgess);
                arrTranSmp = new TranSample[arrSmp.Length];
                for (int i = 0; i < arrTranSmp.Length; i++)
                {
                    arrTranSmp[i] = new TranSample(this.arrSmp[i], "Нет");
                    arrTranSmp[i].DoHistogram(useSturgess);
                }

                lvSample.Items.Clear();
                lvSample.SuspendLayout();
                foreach (Sample s in arrSmp)
                    lvSample.Items.Add(new ListViewItem(new string[] { s.GetName(), "Нет" }));
                lvSample.ResumeLayout();
            }
            catch { }
        }
        void addFactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int n = arrSmp[0].GetLength();
                string mark = string.Format("x<SUB>{0}</SUB>", arrSmp.Length + 1);
                Sample smp = new Sample("Новый признак", mark, new double[n]);
                FactorForm fForm = new FactorForm(smp, "Нет");
                if (fForm.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpNew = new Sample[arrSmp.Length + 1];
                arrSmp.CopyTo(arrSmpNew, 0);
                arrSmpNew[arrSmp.Length] = fForm.GetSample();
                arrSmpNew[arrSmp.Length].DoHistogram(useSturgess);
                arrSmp = arrSmpNew;

                TranSample[] arrTranSmpNew = new TranSample[arrSmp.Length];
                arrTranSmp.CopyTo(arrTranSmpNew, 0);
                TranSample ts = fForm.GetTranSample();
                ts.DoHistogram(useSturgess);
                arrTranSmpNew[arrTranSmp.Length] = ts;
                arrTranSmp = arrTranSmpNew;

                lvSample.Items.Add(new ListViewItem(new string[] { ts.GetName(), ts.GetTransform() }));
            }
            catch { }
        }
        void editFactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvSample.SelectedIndices[0];
                string transform = lvSample.Items[index].SubItems[1].Text;
                FactorForm fForm = new FactorForm(arrSmp[index], transform);
                if (fForm.ShowDialog() != DialogResult.OK)
                    return;
                arrSmp[index] = fForm.GetSample();
                TranSample ts = fForm.GetTranSample();
                ts.DoHistogram(useSturgess);
                arrTranSmp[index] = ts;

                lvSample.Items[index].SubItems[0].Text = arrSmp[index].GetName();
                lvSample.Items[index].SubItems[1].Text = ts.GetTransform();
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

                Sample[] arrTranSmpNew = new TranSample[arrTranSmp.Length - 1];
                for (int i = 0; i < index; i++)
                    arrTranSmpNew[i] = arrTranSmp[i];
                for (int i = index; i < arrTranSmpNew.Length; i++)
                    arrTranSmpNew[i] = arrTranSmp[i + 1];
                arrTranSmp = arrTranSmpNew;

                lvSample.Items.RemoveAt(index);
            }
            catch { }
        }        
        void editDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrTran = new string[arrTranSmp.Length];
                for (int i = 0; i < arrTran.Length; i++)
                    arrTran[i] = ((TranSample)arrTranSmp[i]).GetTransform();
                DataForm daForm = new DataForm(arrSmp);
                if (daForm.ShowDialog() != DialogResult.OK)
                    return;
                this.arrSmp = daForm.GetSamples();
                foreach (Sample s in arrSmp)
                    s.DoHistogram(true);
                arrTranSmp = new TranSample[arrSmp.Length];
                for (int i = 0; i < arrTranSmp.Length; i++)
                {
                    arrTranSmp[i] = new TranSample(this.arrSmp[i], "Нет");
                    arrTranSmp[i].DoHistogram(useSturgess);
                }

                lvSample.Items.Clear();
                lvSample.SuspendLayout();
                for (int i = 0; i < arrSmp.Length; i++)
                    lvSample.Items.Add(new ListViewItem(new string[] {
                        arrSmp[i].GetName(), arrTran[i] }));
                lvSample.ResumeLayout();
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
                string[] arrName = new string[arrTranSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTranSmp[i].GetName();
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTranSmp.Length - 1];
                int index = sfFrom.GetIndex();
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTranSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTranSmp[i + 1];
                Regression reg = new Regression(arrTranSmp[index], arrSmpX);
                string report = reg.GetRegReport();
                RepForm rForm = new RepForm("Построение регрессии", report);
                rForm.ShowDialog();
            }
            catch { }
        }
        void coeffCorrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTranSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTranSmp[i].GetName();
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTranSmp.Length - 1];
                int index = sfFrom.GetIndex();
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTranSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTranSmp[i + 1];
                Regression reg = new Regression(arrTranSmp[index], arrSmpX);
                reg.CheckHypothesises(alpha);
                string report = reg.GetCorrReport();
                RepForm rForm = new RepForm("Корреляционный анализ", report);
                rForm.ShowDialog();
            }
            catch { }
        }
        void regHypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTranSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTranSmp[i].GetName();
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTranSmp.Length - 1];
                int index = sfFrom.GetIndex();
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTranSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTranSmp[i + 1];
                Regression reg = new Regression(arrTranSmp[index], arrSmpX);
                reg.CheckHypothesises(alpha);
                string report = reg.GetHypRegrReport();
                RepForm rForm = new RepForm("Проверка значимости уравнения регрессии", report);
                rForm.ShowDialog();
            }
            catch { }
        }
        void corrHypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTranSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTranSmp[i].GetName();
                SelFactorForm sfFrom = new SelFactorForm(arrName, null);
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                Sample[] arrSmpX = new Sample[arrTranSmp.Length - 1];
                int index = sfFrom.GetIndex();
                for (int i = 0; i < index; i++)
                    arrSmpX[i] = arrTranSmp[i];
                for (int i = index; i < arrSmpX.Length; i++)
                    arrSmpX[i] = arrTranSmp[i + 1];
                Regression reg = new Regression(arrTranSmp[index], arrSmpX);
                reg.CheckHypothesises(alpha);
                string report = reg.GetHypCorrReport();
                RepForm rForm = new RepForm("Проверка значимости коэффициентов корреляции", report);
                rForm.ShowDialog();
            }
            catch { }
        }
        void normDistHypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTranSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTranSmp[i].GetName();
                SelFactorForm sfFrom = new SelFactorForm(arrName,
                    "Выберете исследуемый признак");
                if (sfFrom.ShowDialog() != DialogResult.OK)
                    return;
                int index = sfFrom.GetIndex();
                RepForm rForm = new RepForm("Проверка нормальности выборочного закона распределения",
                    arrSmp[index].GetHypReport());
                rForm.ShowDialog();
            }
            catch { }
        }
        void doIdentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrName = new string[arrTranSmp.Length];
                for (int i = 0; i < arrName.Length; i++)
                    arrName[i] = arrTranSmp[i].GetName();
                SelFactorForm sFormY = new SelFactorForm(arrName, null);
                if (sFormY.ShowDialog() != DialogResult.OK)
                    return;
                SelFactorForm sFormX = new SelFactorForm(arrName,
                    "Выберете влияющий признак");
                if (sFormX.ShowDialog() != DialogResult.OK)
                    return;
                int indexX = sFormX.GetIndex(), indexY = sFormY.GetIndex();
                IdentForm iForm = new IdentForm(arrSmp[indexX],
                    arrSmp[indexY]);
                if (iForm.ShowDialog() != DialogResult.OK)
                    return;
                arrTranSmp[indexX] = new TranSample(arrSmp[indexX], iForm.GetTransform());
                lvSample.Items[indexX].SubItems[1].Text = iForm.GetTransform();
                arrTranSmp[indexX].DoHistogram(useSturgess);
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
            MessageBox.Show("Выполнил Кондауров А.С., АС-05-2");
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
                foreach (Sample s in arrSmp)
                    s.DoHistogram(useSturgess);
                arrTranSmp = new TranSample[arrSmp.Length];
                for (int i = 0; i < arrTranSmp.Length; i++)
                {
                    arrTranSmp[i] = new TranSample(this.arrSmp[i], "Нет");
                    arrTranSmp[i].DoHistogram(useSturgess);
                }

                lvSample.Items.Clear();
                lvSample.SuspendLayout();
                foreach (Sample s in arrSmp)
                    lvSample.Items.Add(new ListViewItem(new string[] { s.GetName(), "Нет" }));
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
    }
}