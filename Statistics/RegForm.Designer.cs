namespace Statistics
{
    partial class RegForm
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
            this.lRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.ListBox();
            this.btnX = new System.Windows.Forms.Button();
            this.lbXY = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXY = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExpr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lRes
            // 
            this.lRes.AutoSize = true;
            this.lRes.Location = new System.Drawing.Point(12, 9);
            this.lRes.Name = "lRes";
            this.lRes.Size = new System.Drawing.Size(225, 13);
            this.lRes.TabIndex = 1;
            this.lRes.Text = "Результат (результирующая переменная): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фактор:";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(12, 38);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(340, 21);
            this.cb.TabIndex = 5;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Преобразования фактора и парные коэффициенты корреляции:";
            // 
            // lbX
            // 
            this.lbX.FormattingEnabled = true;
            this.lbX.Location = new System.Drawing.Point(12, 78);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(340, 134);
            this.lbX.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Структура модели:";
            // 
            // lbS
            // 
            this.lbS.FormattingEnabled = true;
            this.lbS.Location = new System.Drawing.Point(358, 38);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(339, 446);
            this.lbS.TabIndex = 9;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(277, 218);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "Добавить";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lbXY
            // 
            this.lbXY.FormattingEnabled = true;
            this.lbXY.Location = new System.Drawing.Point(12, 275);
            this.lbXY.Name = "lbXY";
            this.lbXY.Size = new System.Drawing.Size(340, 134);
            this.lbXY.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сочетания факторов и парные коэффициенты корреляции:";
            // 
            // btnXY
            // 
            this.btnXY.Location = new System.Drawing.Point(277, 415);
            this.btnXY.Name = "btnXY";
            this.btnXY.Size = new System.Drawing.Size(75, 23);
            this.btnXY.TabIndex = 13;
            this.btnXY.Text = "Добавить";
            this.btnXY.UseVisualStyleBackColor = true;
            this.btnXY.Click += new System.EventHandler(this.btnXY_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(622, 501);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(541, 550);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(622, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 504);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(340, 20);
            this.tb.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Произвольное выражение:";
            // 
            // btnExpr
            // 
            this.btnExpr.Location = new System.Drawing.Point(277, 530);
            this.btnExpr.Name = "btnExpr";
            this.btnExpr.Size = new System.Drawing.Size(75, 23);
            this.btnExpr.TabIndex = 19;
            this.btnExpr.Text = "Добавить";
            this.btnExpr.UseVisualStyleBackColor = true;
            this.btnExpr.Click += new System.EventHandler(this.btnExpr_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 585);
            this.Controls.Add(this.btnExpr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnXY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbXY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegForm";
            this.Text = "Структурная идентификация множественной регрессионной модели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbS;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.ListBox lbXY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXY;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lRes;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExpr;
    }
}