namespace ImageProcessing
{
    partial class Form1
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сглаживающиеФильтрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.х3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.х5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.х7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обычнаяМатрицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильрыПовышенияРезкостиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.операторЛаплассаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обычнаяМатрицаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расширеннаяМатрицаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрCобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.теорияToolStripMenuItem,
            this.практикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьИзображениеToolStripMenuItem,
            this.назToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьИзображениеToolStripMenuItem
            // 
            this.сохранитьИзображениеToolStripMenuItem.Name = "сохранитьИзображениеToolStripMenuItem";
            this.сохранитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.сохранитьИзображениеToolStripMenuItem.Text = "Сохранить изображение";
            this.сохранитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзображениеToolStripMenuItem_Click);
            // 
            // назToolStripMenuItem
            // 
            this.назToolStripMenuItem.Name = "назToolStripMenuItem";
            this.назToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.назToolStripMenuItem.Text = "Назад";
            this.назToolStripMenuItem.Click += new System.EventHandler(this.назToolStripMenuItem_Click);
            // 
            // теорияToolStripMenuItem
            // 
            this.теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            this.теорияToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.теорияToolStripMenuItem.Text = "Теория";
            this.теорияToolStripMenuItem.Click += new System.EventHandler(this.теорияToolStripMenuItem_Click);
            // 
            // практикаToolStripMenuItem
            // 
            this.практикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сглаживающиеФильтрыToolStripMenuItem1,
            this.фильрыПовышенияРезкостиToolStripMenuItem1});
            this.практикаToolStripMenuItem.Name = "практикаToolStripMenuItem";
            this.практикаToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.практикаToolStripMenuItem.Text = "Практика";
            // 
            // сглаживающиеФильтрыToolStripMenuItem1
            // 
            this.сглаживающиеФильтрыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медианныйToolStripMenuItem1,
            this.линейныйToolStripMenuItem1});
            this.сглаживающиеФильтрыToolStripMenuItem1.Name = "сглаживающиеФильтрыToolStripMenuItem1";
            this.сглаживающиеФильтрыToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.сглаживающиеФильтрыToolStripMenuItem1.Text = "Сглаживающие фильтры";
            // 
            // медианныйToolStripMenuItem1
            // 
            this.медианныйToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.х3ToolStripMenuItem1,
            this.х5ToolStripMenuItem1,
            this.х7ToolStripMenuItem});
            this.медианныйToolStripMenuItem1.Name = "медианныйToolStripMenuItem1";
            this.медианныйToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.медианныйToolStripMenuItem1.Text = "Медианный";
            // 
            // х3ToolStripMenuItem1
            // 
            this.х3ToolStripMenuItem1.Name = "х3ToolStripMenuItem1";
            this.х3ToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.х3ToolStripMenuItem1.Text = "3х3";
            this.х3ToolStripMenuItem1.Click += new System.EventHandler(this.х3ToolStripMenuItem1_Click);
            // 
            // х5ToolStripMenuItem1
            // 
            this.х5ToolStripMenuItem1.Name = "х5ToolStripMenuItem1";
            this.х5ToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.х5ToolStripMenuItem1.Text = "5х5";
            this.х5ToolStripMenuItem1.Click += new System.EventHandler(this.х5ToolStripMenuItem1_Click);
            // 
            // х7ToolStripMenuItem
            // 
            this.х7ToolStripMenuItem.Name = "х7ToolStripMenuItem";
            this.х7ToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.х7ToolStripMenuItem.Text = "7х7";
            this.х7ToolStripMenuItem.Click += new System.EventHandler(this.х7ToolStripMenuItem_Click);
            // 
            // линейныйToolStripMenuItem1
            // 
            this.линейныйToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычнаяМатрицаToolStripMenuItem,
            this.маскаToolStripMenuItem});
            this.линейныйToolStripMenuItem1.Name = "линейныйToolStripMenuItem1";
            this.линейныйToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.линейныйToolStripMenuItem1.Text = "Линейный";
            this.линейныйToolStripMenuItem1.Click += new System.EventHandler(this.линейныйToolStripMenuItem1_Click);
            // 
            // обычнаяМатрицаToolStripMenuItem
            // 
            this.обычнаяМатрицаToolStripMenuItem.Name = "обычнаяМатрицаToolStripMenuItem";
            this.обычнаяМатрицаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.обычнаяМатрицаToolStripMenuItem.Text = "Обычная маска";
            this.обычнаяМатрицаToolStripMenuItem.Click += new System.EventHandler(this.обычнаяМатрицаToolStripMenuItem_Click);
            // 
            // маскаToolStripMenuItem
            // 
            this.маскаToolStripMenuItem.Name = "маскаToolStripMenuItem";
            this.маскаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.маскаToolStripMenuItem.Text = "Расширенная маска";
            this.маскаToolStripMenuItem.Click += new System.EventHandler(this.маскаToolStripMenuItem_Click);
            // 
            // фильрыПовышенияРезкостиToolStripMenuItem1
            // 
            this.фильрыПовышенияРезкостиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторЛаплассаToolStripMenuItem1,
            this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1,
            this.фильтрCобеляToolStripMenuItem});
            this.фильрыПовышенияРезкостиToolStripMenuItem1.Name = "фильрыПовышенияРезкостиToolStripMenuItem1";
            this.фильрыПовышенияРезкостиToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.фильрыПовышенияРезкостиToolStripMenuItem1.Text = "Фильры повышения резкости";
            // 
            // операторЛаплассаToolStripMenuItem1
            // 
            this.операторЛаплассаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычнаяМатрицаToolStripMenuItem1,
            this.расширеннаяМатрицаToolStripMenuItem1});
            this.операторЛаплассаToolStripMenuItem1.Name = "операторЛаплассаToolStripMenuItem1";
            this.операторЛаплассаToolStripMenuItem1.Size = new System.Drawing.Size(299, 22);
            this.операторЛаплассаToolStripMenuItem1.Text = "Оператор Лапласса";
            this.операторЛаплассаToolStripMenuItem1.Click += new System.EventHandler(this.операторЛаплассаToolStripMenuItem1_Click);
            // 
            // обычнаяМатрицаToolStripMenuItem1
            // 
            this.обычнаяМатрицаToolStripMenuItem1.Name = "обычнаяМатрицаToolStripMenuItem1";
            this.обычнаяМатрицаToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.обычнаяМатрицаToolStripMenuItem1.Text = "Обычная матрица";
            this.обычнаяМатрицаToolStripMenuItem1.Click += new System.EventHandler(this.обычнаяМатрицаToolStripMenuItem1_Click);
            // 
            // расширеннаяМатрицаToolStripMenuItem1
            // 
            this.расширеннаяМатрицаToolStripMenuItem1.Name = "расширеннаяМатрицаToolStripMenuItem1";
            this.расширеннаяМатрицаToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.расширеннаяМатрицаToolStripMenuItem1.Text = "Расширенная матрица";
            this.расширеннаяМатрицаToolStripMenuItem1.Click += new System.EventHandler(this.расширеннаяМатрицаToolStripMenuItem1_Click);
            // 
            // фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1
            // 
            this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1.Name = "фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1";
            this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1.Size = new System.Drawing.Size(299, 22);
            this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1.Text = "Фильтрация с подъемом высоких частот";
            this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1.Click += new System.EventHandler(this.фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1_Click);
            // 
            // фильтрCобеляToolStripMenuItem
            // 
            this.фильтрCобеляToolStripMenuItem.Name = "фильтрCобеляToolStripMenuItem";
            this.фильтрCобеляToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.фильтрCобеляToolStripMenuItem.Text = "Оператор Cобеля";
            this.фильтрCобеляToolStripMenuItem.Click += new System.EventHandler(this.фильтрCобеляToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(711, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 470);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(693, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(745, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(711, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "K=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сглаживающиеФильтрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem х3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem х5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem линейныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильрыПовышенияРезкостиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem операторЛаплассаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обычнаяМатрицаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расширеннаяМатрицаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрCобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычнаяМатрицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х7ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

