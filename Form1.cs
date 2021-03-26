using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using EasyTabs;

namespace лабораторная_2__web_браузер_
{
    public partial class FormWithTabControl : Form
    {
        private int i = 0;
        public FormWithTabControl()
        {
            InitializeComponent();
            tabControl1.Multiline = true;
            tabControl1.Dock = DockStyle.Fill;         
        }
       
        private void addTubButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;

            tabControl1.TabPages.Add("Новая страница");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;

        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) // отображение названия сайта во вкладке
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void goToPageButton_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != null)
            {
               ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
            else 
            { 

            }          
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void goForwardButtton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void refrashButton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
            else
            {
                Application.Exit();
            }
        }
        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Необходимо создать вкладку");
                }
            }
        }

        private void toEnotherFormButton_Click(object sender, EventArgs e)
        {
            var form = new FormWithTableLayoutPanel(this);
            form.Show();
            
        }
    }
}
