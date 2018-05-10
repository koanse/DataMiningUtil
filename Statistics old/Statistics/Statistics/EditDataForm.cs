using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Statistics
{
    public partial class EditDataForm : Form
    {
        public EditDataForm(string[] arrName, double[] arrData)
        {
            InitializeComponent();
            dgv.Columns["Значение"].ValueType = typeof(double);
            for (int i = 0; i < arrName.Length; i++)
            {
                dgv.Rows.Add(new object[] { arrName[i], arrData[i] });
            }                
        }
        public double[] GetData()
        {
            double[] arrData = new double[dgv.Rows.Count];
            for (int i = 0; i < dgv.Rows.Count; i++)
                arrData[i] = (double)dgv.Rows[i].Cells["Значение"].Value;
            return arrData;
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