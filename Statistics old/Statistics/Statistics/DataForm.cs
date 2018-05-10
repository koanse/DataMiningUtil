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
        public Sample[] arrSmp;
        public string[] arrColName;
        public DataForm(Sample[] arrSmp)
        {
            InitializeComponent();
            this.arrSmp = arrSmp;
            foreach (Sample s in arrSmp)
                dgv.Columns.Add(s.name, s.name);
            int n = arrSmp[0].arr.Length;
            dgv.SuspendLayout();
            for (int i = 0; i < n; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < arrSmp.Length; j++)
                {
                    dgv[j, i].Value = string.Format("{0:f3}", arrSmp[j][i]);
                }
            }
        }
        void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count < 3)
                    return;
                int index = dgv.SelectedCells[0].RowIndex;
                int[] arrIndex = new int[] { index };
                for (int i = 0; i < arrSmp.Length; i++)
                    arrSmp[i].RemoveValues(arrIndex);
                dgv.Rows.RemoveAt(index);
            }
            catch { }
        }
        void btnDropOut_Click(object sender, EventArgs e)
        {
            string[] arrName = new string[arrSmp.Length];
            for (int i = 0; i < arrName.Length; i++)
			{
                arrName[i]=arrSmp[i].name;			 
			}
            SelFactorForm sf = new SelFactorForm(arrName, "Выберете признак");
            if (sf.ShowDialog() != DialogResult.OK)
                return;
            AlphaForm doForm = new AlphaForm();
            if (doForm.ShowDialog() != DialogResult.OK)
                return;
            double alpha = doForm.GetAlpha();
            string rep;
            int[] arrI = arrSmp[sf.index].DropoutErrors(alpha, out rep);
            foreach (Sample smp in arrSmp)
            {
                smp.RemoveValues(arrI);
            }
            dgv.SuspendLayout();
            for (int i = arrI.Length - 1; i >= 0; i--)
            {
                dgv.Rows.RemoveAt(i);
            }            
            RepForm rForm = new RepForm("Отсев аномальных измерений", rep);
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