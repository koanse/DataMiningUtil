using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Statistics
{
    public partial class ImportForm : Form
    {
        Sample[] arrSmp;
        public ImportForm()
        {
            InitializeComponent();
            //tbFile.Text = "C:\\Documents and Settings\\COMP\\Мои документы\\Идентификация систем\\Лр1.xls";
            //tbFile.Text = "D:\\Шара\\Копия Лр1.xls";
            //tbSheet.Text = "Модели";
            //tbRange.Text = "A1:C40";
        }
        public Sample[] GetSamples()
        {
            return arrSmp;
        }
        void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbFile.Text = openFileDialog1.FileName;
        }
        void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "provider = Microsoft.Jet.OLEDB.4.0;" +
                    "data source = " + tbFile.Text + ";" +
                    "extended properties = Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(s);
                string sheet = tbSheet.Text.Replace('.', '#');
                s = string.Format("SELECT * FROM [{0}${1}]",
                    sheet, tbRange.Text);
                OleDbDataAdapter da = new OleDbDataAdapter(s, conn);
                conn.Open();
                DataTable dtData = new DataTable();
                da.Fill(dtData);
                conn.Close();

                arrSmp = new Sample[dtData.Columns.Count];
                double[][] matrData = new double[arrSmp.Length][];
                int n = dtData.Rows.Count;
                for (int i = 0; i < matrData.Length; i++)
                    matrData[i] = new double[n];
                for (int i = 0; i < dtData.Rows.Count; i++)
                    for (int j = 0; j < dtData.Columns.Count; j++)
                    {
                        double x;
                        if (!double.TryParse(dtData.Rows[i][j].ToString(), out x))
                            x = 0;
                        matrData[j][i] = x;                        
                    }

                for (int i = 0; i < arrSmp.Length; i++)
                {
                    string name;
                    name = (string)dtData.Columns[i].ColumnName;
                    string idHtml = string.Format("x<SUB>{0}</SUB>", i + 1);
                    arrSmp[i] = new Sample(name, idHtml, matrData[i]);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка импорта данных");
            }
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        void tb_TextChanged(object sender, EventArgs e)
        {
            TryPreview();
        }
        void TryPreview()
        {
            try
            {
                lbName.Items.Clear();
                string s = "provider = Microsoft.Jet.OLEDB.4.0;" +
                    "data source = " + tbFile.Text + ";" +
                    "extended properties = Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(s);
                string sheet = tbSheet.Text.Replace('.', '#');
                s = string.Format("SELECT * FROM [{0}${1}]",
                    sheet, tbRange.Text);
                OleDbDataAdapter da = new OleDbDataAdapter(s, conn);
                conn.Open();
                DataTable dtData = new DataTable();
                da.FillSchema(dtData, SchemaType.Source);
                conn.Close();                
                foreach (DataColumn c in dtData.Columns)
                    lbName.Items.Add((string)c.ColumnName);
            }
            catch { }
        }
    }
}