namespace лабораторная_2__web_браузер_
{
    partial class FormWithTabControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWithTabControl));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.goForwardButtton = new System.Windows.Forms.ToolStripButton();
            this.refrashButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goToPageButton = new System.Windows.Forms.ToolStripButton();
            this.addTubButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.ToEnotherFormButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьНаДискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1104, 564);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.goForwardButtton,
            this.refrashButton,
            this.toolStripTextBox1,
            this.goToPageButton,
            this.addTubButton,
            this.deleteButton,
            this.ToEnotherFormButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1128, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(34, 33);
            this.backButton.Text = "toolStripButton1";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goForwardButtton
            // 
            this.goForwardButtton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goForwardButtton.Image = ((System.Drawing.Image)(resources.GetObject("goForwardButtton.Image")));
            this.goForwardButtton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goForwardButtton.Name = "goForwardButtton";
            this.goForwardButtton.Size = new System.Drawing.Size(34, 28);
            this.goForwardButtton.Text = "toolStripButton2";
            this.goForwardButtton.Click += new System.EventHandler(this.goForwardButtton_Click);
            // 
            // refrashButton
            // 
            this.refrashButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refrashButton.Image = ((System.Drawing.Image)(resources.GetObject("refrashButton.Image")));
            this.refrashButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrashButton.Name = "refrashButton";
            this.refrashButton.Size = new System.Drawing.Size(34, 28);
            this.refrashButton.Text = "toolStripButton3";
            this.refrashButton.Click += new System.EventHandler(this.refrashButton_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(600, 33);
            this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            // 
            // goToPageButton
            // 
            this.goToPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToPageButton.Image = ((System.Drawing.Image)(resources.GetObject("goToPageButton.Image")));
            this.goToPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goToPageButton.Name = "goToPageButton";
            this.goToPageButton.Size = new System.Drawing.Size(34, 28);
            this.goToPageButton.Text = "toolStripButton5";
            this.goToPageButton.Click += new System.EventHandler(this.goToPageButton_Click);
            // 
            // addTubButton
            // 
            this.addTubButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTubButton.Image = ((System.Drawing.Image)(resources.GetObject("addTubButton.Image")));
            this.addTubButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTubButton.Name = "addTubButton";
            this.addTubButton.Size = new System.Drawing.Size(34, 28);
            this.addTubButton.Text = "toolStripButton6";
            this.addTubButton.Click += new System.EventHandler(this.addTubButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(34, 28);
            this.deleteButton.Text = "toolStripButton4";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ToEnotherFormButton
            // 
            this.ToEnotherFormButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToEnotherFormButton.Image = ((System.Drawing.Image)(resources.GetObject("ToEnotherFormButton.Image")));
            this.ToEnotherFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToEnotherFormButton.Name = "ToEnotherFormButton";
            this.ToEnotherFormButton.Size = new System.Drawing.Size(34, 28);
            this.ToEnotherFormButton.Text = "toolStripButton1";
            this.ToEnotherFormButton.Click += new System.EventHandler(this.toEnotherFormButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 550);
            this.tabControl1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьНаДискеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 36);
            // 
            // сохранитьНаДискеToolStripMenuItem
            // 
            this.сохранитьНаДискеToolStripMenuItem.Name = "сохранитьНаДискеToolStripMenuItem";
            this.сохранитьНаДискеToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.сохранитьНаДискеToolStripMenuItem.Text = "Сохранить на диске";
            // 
            // FormWithTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 588);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWithTabControl";
            this.Text = "ArViMi~Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton goForwardButtton;
        private System.Windows.Forms.ToolStripButton refrashButton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton goToPageButton;
        private System.Windows.Forms.ToolStripButton addTubButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНаДискеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton ToEnotherFormButton;
    }
}

