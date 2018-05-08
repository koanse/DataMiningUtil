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
    public partial class DataForm : Form
    {
        public DataForm(Sample[] arr)
        {
            InitializeComponent();
            dgv.SuspendLayout();
            foreach (Sample s in arr)
            {
                dgv.Columns.Add(s.name, s.name);
            }
            for (int i = 0; i < arr[0].arr.Length; i++)
            {
                List<object> lo = new List<object>();
                foreach (Sample s in arr)
                {
                    lo.Add(s.arr[i]);
                }
                dgv.Rows.Add(lo.ToArray());
            }
            dgv.ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
