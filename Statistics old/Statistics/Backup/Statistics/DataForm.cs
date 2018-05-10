using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class DataForm : Form
    {
        Sample[] arrSmp;
        string[] arrColName;
        public DataForm(Sample[] arrSmp)
        {
            InitializeComponent();
            this.arrSmp = new Sample[arrSmp.Length];
            for (int i = 0; i < arrSmp.Length; i++)
                this.arrSmp[i] = (Sample)arrSmp[i].Clone();
            foreach (Sample s in arrSmp)
                lvData.Columns.Add(s.GetName());
            int n = arrSmp[0].GetLength();
            lvData.SuspendLayout();
            for (int i = 0; i < n; i++)
            {
                string[] arrStr = new string[arrSmp.Length];
                for (int j = 0; j < arrSmp.Length; j++)
                    arrStr[j] = arrSmp[j][i].ToString();
                lvData.Items.Add(new ListViewItem(arrStr));
            }
            lvData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvData.ResumeLayout();
            arrColName = new string[arrSmp.Length];
            for (int i = 0; i < lvData.Columns.Count; i++)
                arrColName[i] = lvData.Columns[i].Text;
        }
        public Sample[] GetSamples()
        {
            return arrSmp;
        }
        void btnAdd_Click(object sender, EventArgs e)
        {
            double[] arrData = new double[lvData.Columns.Count];
            EditDataForm edForm = new EditDataForm(arrColName, arrData);
            if (edForm.ShowDialog() != DialogResult.OK)
                return;
            string[] arrStr = new string[lvData.Columns.Count];
            double[] arrValue = edForm.GetData();
            for (int i = 0; i < lvData.Columns.Count; i++)
            {
                arrSmp[i].AddValue(arrValue[i]);
                arrStr[i] = arrValue[i].ToString();
            }
            lvData.Items.Add(new ListViewItem(arrStr));
        }
        void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lvData.SelectedIndices[0];
                double[] arrData = new double[lvData.Columns.Count];
                for (int i = 0; i < arrData.Length; i++)
                    arrData[i] = arrSmp[i][index];
                EditDataForm edForm = new EditDataForm(arrColName, arrData);
                if (edForm.ShowDialog() != DialogResult.OK)
                    return;
                string[] arrStr = new string[lvData.Columns.Count];
                double[] arrValue = edForm.GetData();
                for (int i = 0; i < lvData.Columns.Count; i++)
                {
                    arrSmp[i][index] = arrValue[i];
                    arrStr[i] = arrValue[i].ToString();
                }
                lvData.Items.RemoveAt(index);
                lvData.Items.Insert(index, new ListViewItem(arrStr));
            }
            catch { }
        }
        void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvData.Items.Count < 3)
                    return;
                int index = lvData.SelectedIndices[0];
                int[] arrIndex = new int[] { index };
                for (int i = 0; i < lvData.Columns.Count; i++)
                    arrSmp[i].RemoveValues(arrIndex);
                lvData.Items.RemoveAt(index);
            }
            catch { }
        }
        void btnDropOut_Click(object sender, EventArgs e)
        {
            string strRep = "</P>ОТСЕВ ГРУБЫХ ПОГРЕШНОСТЕЙ (";
            bool useStud;
            if (lvData.Items.Count > 25)
            {
                useStud = true;
                strRep += "распределение Стьюдента";
            }
            else
            {
                useStud = false;
                strRep += "распределение максимального относительного отклонения";
            }
            strRep += ")<BR><TABLE BORDER = 3><TR>";
            for (int i = 0; i < arrSmp.Length; i++)
                strRep += string.Format("<TD>{0}</TD>", arrSmp[i].GetMark());
            strRep += "</TR>";
            
            DropOutForm doForm = new DropOutForm(useStud);
            if (doForm.ShowDialog() != DialogResult.OK)
                return;
            double alpha = doForm.GetAlpha();
            
            lvData.SuspendLayout();
            while (true)
            {
                List<int> listIndexRemove = new List<int>();
                foreach (Sample s in arrSmp)
                {
                    int[] arrIndexRemove;
                    if (doForm.UseStudent())
                        arrIndexRemove = s.DropoutErrorsStud(alpha, -1);
                    else
                        arrIndexRemove = s.DropoutErrorsTau(alpha);
                    foreach (int index in arrIndexRemove)
                    {
                        int pos = listIndexRemove.BinarySearch(index);
                        if (pos < 0)
                            listIndexRemove.Insert(~pos, index);
                    }
                }
                if (listIndexRemove.Count == 0)
                    break;
                int[] arrIndex = listIndexRemove.ToArray();
                for (int i = 0; i < arrIndex.Length; i++)
                {
                    strRep += "<TR>";
                    for (int j = 0; j < arrSmp.Length; j++)
                        strRep += string.Format("<TD>{0}</TD>", arrSmp[j][i]);
                    strRep += "</TR>";
                }
                foreach (Sample s in arrSmp)
                    s.RemoveValues(arrIndex);
                listIndexRemove.Reverse();
                foreach (int index in listIndexRemove)
                    lvData.Items.RemoveAt(index);
            }
            strRep += "</TABLE></P>";
            lvData.ResumeLayout();
            RepForm rForm = new RepForm("Отсев грубых погрешностей", strRep);
            rForm.ShowDialog();
        }
        void btnOk_Click(object sender, EventArgs e)
        {
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