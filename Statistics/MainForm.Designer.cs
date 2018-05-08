namespace Statistics
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.btnDrop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckNorm = new System.Windows.Forms.Button();
            this.btnCorr = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCheckCorr = new System.Windows.Forms.Button();
            this.btnCheckReg = new System.Windows.Forms.Button();
            this.btnNorm = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExcelToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openExcelToolStripMenuItem
            // 
            this.openExcelToolStripMenuItem.Name = "openExcelToolStripMenuItem";
            this.openExcelToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openExcelToolStripMenuItem.Text = "Импорт данных из Excel";
            this.openExcelToolStripMenuItem.Click += new System.EventHandler(this.openExcelToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(12, 49);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(319, 303);
            this.lb.TabIndex = 1;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Format = "{0:g4}";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(337, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.LabelFormat = "{0:f4}";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(462, 186);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(337, 219);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(462, 325);
            this.wb.TabIndex = 3;
            // 
            // btnDrop
            // 
            this.btnDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDrop.Location = new System.Drawing.Point(12, 387);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(181, 23);
            this.btnDrop.TabIndex = 4;
            this.btnDrop.Text = "Отсев аномальных измерений";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Переменные:";
            // 
            // btnCheckNorm
            // 
            this.btnCheckNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckNorm.Location = new System.Drawing.Point(12, 358);
            this.btnCheckNorm.Name = "btnCheckNorm";
            this.btnCheckNorm.Size = new System.Drawing.Size(181, 23);
            this.btnCheckNorm.TabIndex = 6;
            this.btnCheckNorm.Text = "Проверка нормальности";
            this.btnCheckNorm.UseVisualStyleBackColor = true;
            this.btnCheckNorm.Click += new System.EventHandler(this.btnCheckNorm_Click);
            // 
            // btnCorr
            // 
            this.btnCorr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCorr.Location = new System.Drawing.Point(12, 416);
            this.btnCorr.Name = "btnCorr";
            this.btnCorr.Size = new System.Drawing.Size(181, 23);
            this.btnCorr.TabIndex = 7;
            this.btnCorr.Text = "Корреляционный анализ";
            this.btnCorr.UseVisualStyleBackColor = true;
            this.btnCorr.Click += new System.EventHandler(this.btnCorr_Click);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReg.Location = new System.Drawing.Point(12, 476);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(319, 23);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "Множественный регрессионный анализ";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(246, 358);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCheckCorr
            // 
            this.btnCheckCorr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckCorr.Location = new System.Drawing.Point(12, 445);
            this.btnCheckCorr.Name = "btnCheckCorr";
            this.btnCheckCorr.Size = new System.Drawing.Size(319, 23);
            this.btnCheckCorr.TabIndex = 10;
            this.btnCheckCorr.Text = "Проверка значимости коэффициентов корреляции";
            this.btnCheckCorr.UseVisualStyleBackColor = true;
            this.btnCheckCorr.Click += new System.EventHandler(this.btnCheckCorr_Click);
            // 
            // btnCheckReg
            // 
            this.btnCheckReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckReg.Location = new System.Drawing.Point(12, 505);
            this.btnCheckReg.Name = "btnCheckReg";
            this.btnCheckReg.Size = new System.Drawing.Size(319, 39);
            this.btnCheckReg.TabIndex = 11;
            this.btnCheckReg.Text = "Проверка значимости уравнения множественной регрессии";
            this.btnCheckReg.UseVisualStyleBackColor = true;
            this.btnCheckReg.Click += new System.EventHandler(this.btnCheckReg_Click);
            // 
            // btnNorm
            // 
            this.btnNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNorm.Location = new System.Drawing.Point(246, 387);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.Size = new System.Drawing.Size(85, 23);
            this.btnNorm.TabIndex = 12;
            this.btnNorm.Text = "Нормировка";
            this.btnNorm.UseVisualStyleBackColor = true;
            this.btnNorm.Click += new System.EventHandler(this.btnNorm_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnView.Location = new System.Drawing.Point(246, 416);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(85, 23);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "Просмотр";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 556);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnNorm);
            this.Controls.Add(this.btnCheckReg);
            this.Controls.Add(this.btnCheckCorr);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnCorr);
            this.Controls.Add(this.btnCheckNorm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Система извлечения информации из данных методами математической статистики";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckNorm;
        private System.Windows.Forms.Button btnCorr;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCheckCorr;
        private System.Windows.Forms.Button btnCheckReg;
        private System.Windows.Forms.Button btnNorm;
        private System.Windows.Forms.Button btnView;
    }
}

