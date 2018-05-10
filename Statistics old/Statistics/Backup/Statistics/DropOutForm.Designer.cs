namespace Statistics
{
    partial class DropOutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbTau = new System.Windows.Forms.RadioButton();
            this.rbStud = new System.Windows.Forms.RadioButton();
            this.tbAlpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(301, 127);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rbTau
            // 
            this.rbTau.AutoSize = true;
            this.rbTau.Checked = true;
            this.rbTau.Location = new System.Drawing.Point(6, 19);
            this.rbTau.Name = "rbTau";
            this.rbTau.Size = new System.Drawing.Size(334, 17);
            this.rbTau.TabIndex = 14;
            this.rbTau.TabStop = true;
            this.rbTau.Text = "Распределение максимального относительного отклонения";
            this.rbTau.UseVisualStyleBackColor = true;
            // 
            // rbStud
            // 
            this.rbStud.AutoSize = true;
            this.rbStud.Location = new System.Drawing.Point(6, 42);
            this.rbStud.Name = "rbStud";
            this.rbStud.Size = new System.Drawing.Size(162, 17);
            this.rbStud.TabIndex = 15;
            this.rbStud.TabStop = true;
            this.rbStud.Text = "Распределение Стьюдента";
            this.rbStud.UseVisualStyleBackColor = true;
            // 
            // tbAlpha
            // 
            this.tbAlpha.Location = new System.Drawing.Point(12, 101);
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(445, 20);
            this.tbAlpha.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Уровень значимости:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTau);
            this.groupBox1.Controls.Add(this.rbStud);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 70);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Распределение";
            // 
            // DropOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 166);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAlpha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DropOutForm";
            this.ShowIcon = false;
            this.Text = "Отсев грубых погрешностей";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rbTau;
        private System.Windows.Forms.RadioButton rbStud;
        private System.Windows.Forms.TextBox tbAlpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}