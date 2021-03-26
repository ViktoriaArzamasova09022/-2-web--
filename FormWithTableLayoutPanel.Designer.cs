namespace лабораторная_2__web_браузер_
{
    partial class FormWithTableLayoutPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWithTableLayoutPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ToEnotherFormButton2 = new System.Windows.Forms.Button();
            this.openFixPages = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.RefrashButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.FixButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.historyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьНаДискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзИсторииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zakladkyListBox = new System.Windows.Forms.ListBox();
            this.zakladkyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьИзЗакладокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.historyMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.zakladkyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ToEnotherFormButton2, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.openFixPages, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ForwardButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RefrashButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.FixButton, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 92);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ToEnotherFormButton2
            // 
            this.ToEnotherFormButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToEnotherFormButton2.Location = new System.Drawing.Point(773, 3);
            this.ToEnotherFormButton2.Name = "ToEnotherFormButton2";
            this.ToEnotherFormButton2.Size = new System.Drawing.Size(130, 44);
            this.ToEnotherFormButton2.TabIndex = 9;
            this.ToEnotherFormButton2.Text = "*";
            this.ToEnotherFormButton2.UseVisualStyleBackColor = true;
            this.ToEnotherFormButton2.Click += new System.EventHandler(this.openFixPages_Click);
            // 
            // openFixPages
            // 
            this.openFixPages.Location = new System.Drawing.Point(909, 3);
            this.openFixPages.Name = "openFixPages";
            this.openFixPages.Size = new System.Drawing.Size(60, 42);
            this.openFixPages.TabIndex = 8;
            this.openFixPages.Text = "->";
            this.openFixPages.UseVisualStyleBackColor = true;
            this.openFixPages.Click += new System.EventHandler(this.toEnotherFormButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(336, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPageKey);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 44);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForwardButton.Location = new System.Drawing.Point(98, 3);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(102, 44);
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.Text = "Вперед";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RefrashButton
            // 
            this.RefrashButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefrashButton.Location = new System.Drawing.Point(206, 3);
            this.RefrashButton.Name = "RefrashButton";
            this.RefrashButton.Size = new System.Drawing.Size(124, 44);
            this.RefrashButton.TabIndex = 3;
            this.RefrashButton.Text = "Обновить";
            this.RefrashButton.UseVisualStyleBackColor = true;
            this.RefrashButton.Click += new System.EventHandler(this.RefrashButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GoButton.Image = global::лабораторная_2__web_браузер_.Properties.Resources.стрела2;
            this.GoButton.Location = new System.Drawing.Point(712, 3);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(55, 44);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            this.GoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPageKey);
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Location = new System.Drawing.Point(206, 53);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(124, 36);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FixButton
            // 
            this.FixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FixButton.Location = new System.Drawing.Point(773, 53);
            this.FixButton.Name = "FixButton";
            this.FixButton.Size = new System.Drawing.Size(130, 36);
            this.FixButton.TabIndex = 11;
            this.FixButton.Text = "В закладки";
            this.FixButton.UseVisualStyleBackColor = true;
            this.FixButton.Click += new System.EventHandler(this.FixButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel2.Controls.Add(this.webBrowser1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 91);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 511);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(972, 505);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(981, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.historyListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "История";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // historyListBox
            // 
            this.historyListBox.ContextMenuStrip = this.historyMenuStrip;
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 20;
            this.historyListBox.Location = new System.Drawing.Point(3, 3);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(0, 466);
            this.historyListBox.TabIndex = 0;
            // 
            // historyMenuStrip
            // 
            this.historyMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.historyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьНаДискеToolStripMenuItem,
            this.удалитьИзИсторииToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem});
            this.historyMenuStrip.Name = "contextMenuStrip1";
            this.historyMenuStrip.Size = new System.Drawing.Size(246, 100);
            // 
            // сохранитьНаДискеToolStripMenuItem
            // 
            this.сохранитьНаДискеToolStripMenuItem.Name = "сохранитьНаДискеToolStripMenuItem";
            this.сохранитьНаДискеToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.сохранитьНаДискеToolStripMenuItem.Text = "Сохранить на диске";
            this.сохранитьНаДискеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьНаДискеToolStripMenuItem_Click);
            // 
            // удалитьИзИсторииToolStripMenuItem
            // 
            this.удалитьИзИсторииToolStripMenuItem.Name = "удалитьИзИсторииToolStripMenuItem";
            this.удалитьИзИсторииToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.удалитьИзИсторииToolStripMenuItem.Text = "Удалить из истории";
            this.удалитьИзИсторииToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзИсторииToolStripMenuItem_Click);
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсеToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zakladkyListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Закладки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zakladkyListBox
            // 
            this.zakladkyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zakladkyListBox.FormattingEnabled = true;
            this.zakladkyListBox.ItemHeight = 20;
            this.zakladkyListBox.Location = new System.Drawing.Point(3, 3);
            this.zakladkyListBox.Name = "zakladkyListBox";
            this.zakladkyListBox.Size = new System.Drawing.Size(0, 466);
            this.zakladkyListBox.TabIndex = 0;
            this.zakladkyListBox.Click += new System.EventHandler(this.GoOnFixPage);
            // 
            // zakladkyMenuStrip
            // 
            this.zakladkyMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.zakladkyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьИзЗакладокToolStripMenuItem});
            this.zakladkyMenuStrip.Name = "zakladkyMenuStrip";
            this.zakladkyMenuStrip.Size = new System.Drawing.Size(251, 36);
            // 
            // удалитьИзЗакладокToolStripMenuItem
            // 
            this.удалитьИзЗакладокToolStripMenuItem.Name = "удалитьИзЗакладокToolStripMenuItem";
            this.удалитьИзЗакладокToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.удалитьИзЗакладокToolStripMenuItem.Text = "Удалить из закладок";
            this.удалитьИзЗакладокToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзЗакладокToolStripMenuItem_Click);
            // 
            // FormWithTableLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 602);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWithTableLayoutPanel";
            this.Text = "ArViMi~Browser";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.historyMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.zakladkyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button RefrashButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button ToEnotherFormButton2;
        private System.Windows.Forms.Button openFixPages;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.ListBox zakladkyListBox;
        private System.Windows.Forms.ContextMenuStrip historyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНаДискеToolStripMenuItem;
        private System.Windows.Forms.Button FixButton;
        private System.Windows.Forms.ContextMenuStrip zakladkyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзЗакладокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзИсторииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
    }
}