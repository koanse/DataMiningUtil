namespace Statistics
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doIdentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.corrAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coeffCorrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regHypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corrHypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normDistHypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.histToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sturgessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvSample = new System.Windows.Forms.ListView();
            this.Признак = new System.Windows.Forms.ColumnHeader();
            this.Преобразование = new System.Windows.Forms.ColumnHeader();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.psHist = new NPlot.Windows.PlotSurface2D();
            this.wbSample = new System.Windows.Forms.WebBrowser();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.regAnToolStripMenuItem,
            this.corrAnToolStripMenuItem,
            this.hypToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.openToolStripMenuItem.Text = "Открыть файл MS Excel";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFactorToolStripMenuItem,
            this.editFactorToolStripMenuItem,
            this.removeFactorToolStripMenuItem,
            this.editDataToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // addFactorToolStripMenuItem
            // 
            this.addFactorToolStripMenuItem.Name = "addFactorToolStripMenuItem";
            this.addFactorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addFactorToolStripMenuItem.Text = "Добавить признак";
            this.addFactorToolStripMenuItem.Click += new System.EventHandler(this.addFactorToolStripMenuItem_Click);
            // 
            // editFactorToolStripMenuItem
            // 
            this.editFactorToolStripMenuItem.Name = "editFactorToolStripMenuItem";
            this.editFactorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editFactorToolStripMenuItem.Text = "Изменить признак";
            this.editFactorToolStripMenuItem.Click += new System.EventHandler(this.editFactorToolStripMenuItem_Click);
            // 
            // removeFactorToolStripMenuItem
            // 
            this.removeFactorToolStripMenuItem.Name = "removeFactorToolStripMenuItem";
            this.removeFactorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.removeFactorToolStripMenuItem.Text = "Удалить признак";
            this.removeFactorToolStripMenuItem.Click += new System.EventHandler(this.removeFactorToolStripMenuItem_Click);
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            this.editDataToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editDataToolStripMenuItem.Text = "Отсев погрешностей";
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // regAnToolStripMenuItem
            // 
            this.regAnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regressionToolStripMenuItem,
            this.doIdentToolStripMenuItem1});
            this.regAnToolStripMenuItem.Name = "regAnToolStripMenuItem";
            this.regAnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.regAnToolStripMenuItem.Text = "Регрессия";
            // 
            // regressionToolStripMenuItem
            // 
            this.regressionToolStripMenuItem.Name = "regressionToolStripMenuItem";
            this.regressionToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.regressionToolStripMenuItem.Text = "Множественная регрессия";
            this.regressionToolStripMenuItem.Click += new System.EventHandler(this.regressionToolStripMenuItem_Click);
            // 
            // doIdentToolStripMenuItem1
            // 
            this.doIdentToolStripMenuItem1.Name = "doIdentToolStripMenuItem1";
            this.doIdentToolStripMenuItem1.Size = new System.Drawing.Size(236, 22);
            this.doIdentToolStripMenuItem1.Text = "Структурная идентификация";
            this.doIdentToolStripMenuItem1.Click += new System.EventHandler(this.doIdentToolStripMenuItem_Click);
            // 
            // corrAnToolStripMenuItem
            // 
            this.corrAnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coeffCorrToolStripMenuItem});
            this.corrAnToolStripMenuItem.Name = "corrAnToolStripMenuItem";
            this.corrAnToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.corrAnToolStripMenuItem.Text = "Корреляция";
            // 
            // coeffCorrToolStripMenuItem
            // 
            this.coeffCorrToolStripMenuItem.Name = "coeffCorrToolStripMenuItem";
            this.coeffCorrToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.coeffCorrToolStripMenuItem.Text = "Коэффициенты корреляции";
            this.coeffCorrToolStripMenuItem.Click += new System.EventHandler(this.coeffCorrToolStripMenuItem_Click);
            // 
            // hypToolStripMenuItem
            // 
            this.hypToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regHypToolStripMenuItem,
            this.corrHypToolStripMenuItem,
            this.normDistHypToolStripMenuItem});
            this.hypToolStripMenuItem.Name = "hypToolStripMenuItem";
            this.hypToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.hypToolStripMenuItem.Text = "Гипотезы";
            // 
            // regHypToolStripMenuItem
            // 
            this.regHypToolStripMenuItem.Name = "regHypToolStripMenuItem";
            this.regHypToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.regHypToolStripMenuItem.Text = "Значимость уравнения регрессии";
            this.regHypToolStripMenuItem.Click += new System.EventHandler(this.regHypToolStripMenuItem_Click);
            // 
            // corrHypToolStripMenuItem
            // 
            this.corrHypToolStripMenuItem.Name = "corrHypToolStripMenuItem";
            this.corrHypToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.corrHypToolStripMenuItem.Text = "Значимость коэффициентов корреляции";
            this.corrHypToolStripMenuItem.Click += new System.EventHandler(this.corrHypToolStripMenuItem_Click);
            // 
            // normDistHypToolStripMenuItem
            // 
            this.normDistHypToolStripMenuItem.Name = "normDistHypToolStripMenuItem";
            this.normDistHypToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.normDistHypToolStripMenuItem.Text = "Нормальность закона распределения";
            this.normDistHypToolStripMenuItem.Click += new System.EventHandler(this.normDistHypToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphaToolStripMenuItem,
            this.histToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // alphaToolStripMenuItem
            // 
            this.alphaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alphaToolStripTextBox});
            this.alphaToolStripMenuItem.Name = "alphaToolStripMenuItem";
            this.alphaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.alphaToolStripMenuItem.Text = "Уровень значимости";
            // 
            // alphaToolStripTextBox
            // 
            this.alphaToolStripTextBox.Name = "alphaToolStripTextBox";
            this.alphaToolStripTextBox.Size = new System.Drawing.Size(100, 21);
            this.alphaToolStripTextBox.Text = "0,05";
            this.alphaToolStripTextBox.TextChanged += new System.EventHandler(this.alphaToolStripTextBox_TextChanged);
            // 
            // histToolStripMenuItem
            // 
            this.histToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sturgessToolStripMenuItem});
            this.histToolStripMenuItem.Name = "histToolStripMenuItem";
            this.histToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.histToolStripMenuItem.Text = "Построение гистограммы";
            // 
            // sturgessToolStripMenuItem
            // 
            this.sturgessToolStripMenuItem.Checked = true;
            this.sturgessToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sturgessToolStripMenuItem.Name = "sturgessToolStripMenuItem";
            this.sturgessToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sturgessToolStripMenuItem.Text = "Формула Старжесса";
            this.sturgessToolStripMenuItem.Click += new System.EventHandler(this.sturgessToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBoxToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.aboutToolStripMenuItem.Text = "Справка";
            // 
            // aboutBoxToolStripMenuItem
            // 
            this.aboutBoxToolStripMenuItem.Name = "aboutBoxToolStripMenuItem";
            this.aboutBoxToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutBoxToolStripMenuItem.Text = "О программе";
            this.aboutBoxToolStripMenuItem.Click += new System.EventHandler(this.aboutBoxToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvSample);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(679, 348);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvSample
            // 
            this.lvSample.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Признак,
            this.Преобразование});
            this.lvSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSample.FullRowSelect = true;
            this.lvSample.GridLines = true;
            this.lvSample.Location = new System.Drawing.Point(0, 0);
            this.lvSample.Name = "lvSample";
            this.lvSample.Size = new System.Drawing.Size(224, 348);
            this.lvSample.TabIndex = 0;
            this.lvSample.UseCompatibleStateImageBehavior = false;
            this.lvSample.View = System.Windows.Forms.View.Details;
            this.lvSample.SelectedIndexChanged += new System.EventHandler(this.lvSample_SelectedIndexChanged);
            // 
            // Признак
            // 
            this.Признак.Text = "Признак";
            this.Признак.Width = 97;
            // 
            // Преобразование
            // 
            this.Преобразование.Text = "Преобразование";
            this.Преобразование.Width = 123;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.psHist);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.wbSample);
            this.splitContainer2.Size = new System.Drawing.Size(451, 348);
            this.splitContainer2.SplitterDistance = 139;
            this.splitContainer2.TabIndex = 0;
            // 
            // psHist
            // 
            this.psHist.AutoScaleAutoGeneratedAxes = false;
            this.psHist.AutoScaleTitle = false;
            this.psHist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.psHist.DateTimeToolTip = false;
            this.psHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psHist.Legend = null;
            this.psHist.LegendZOrder = -1;
            this.psHist.Location = new System.Drawing.Point(0, 0);
            this.psHist.Name = "psHist";
            this.psHist.RightMenu = null;
            this.psHist.ShowCoordinates = true;
            this.psHist.Size = new System.Drawing.Size(451, 139);
            this.psHist.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.psHist.TabIndex = 0;
            this.psHist.Text = "plotSurface2D1";
            this.psHist.Title = "";
            this.psHist.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.psHist.XAxis1 = null;
            this.psHist.XAxis2 = null;
            this.psHist.YAxis1 = null;
            this.psHist.YAxis2 = null;
            // 
            // wbSample
            // 
            this.wbSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbSample.IsWebBrowserContextMenuEnabled = false;
            this.wbSample.Location = new System.Drawing.Point(0, 0);
            this.wbSample.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSample.Name = "wbSample";
            this.wbSample.Size = new System.Drawing.Size(451, 205);
            this.wbSample.TabIndex = 0;
            this.wbSample.WebBrowserShortcutsEnabled = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.saveToolStripMenuItem.Text = "Сохранить файл с исходными данными";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(284, 22);
            this.openToolStripMenuItem1.Text = "Открыть файл с исходными данными";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Файлы *.smp|*.smp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Файлы *.smp|*.smp";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Содержание";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 372);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Обработка экспериментальных данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private NPlot.Windows.PlotSurface2D psHist;
        private System.Windows.Forms.WebBrowser wbSample;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFactorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFactorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFactorToolStripMenuItem;
        private System.Windows.Forms.ListView lvSample;
        private System.Windows.Forms.ColumnHeader Признак;
        private System.Windows.Forms.ColumnHeader Преобразование;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corrAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coeffCorrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regHypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corrHypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox alphaToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem histToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sturgessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normDistHypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doIdentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}