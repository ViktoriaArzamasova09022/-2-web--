using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторная_2__web_браузер_
{
    public partial class FormWithTableLayoutPanel : Form
    {
        public FormWithTableLayoutPanel()
        {
            InitializeComponent();
        }
        public FormWithTableLayoutPanel(FormWithTabControl f)
        {
            InitializeComponent();         
        }

        private void toEnotherFormButton2_Click(object sender, EventArgs e)
        {
            var form2 = new FormWithTabControl();
            form2.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void RefrashButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }
            
        private void NewPageKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
                historyListBox.Items.Add(textBox1.Text);
            }
        }

        private void openFixPages_Click(object sender, EventArgs e)
        {
            int newWight = 30;
            if (tableLayoutPanel2.ColumnStyles[1].Width == 0)
            {
                tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel2.ColumnStyles[1].Width = newWight;
            }
            else
            {
                tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Absolute;
                tableLayoutPanel2.ColumnStyles[1].Width = 0;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }                    
        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate(textBox1.Text);
                historyListBox.Items.Add(textBox1.Text);
            }
            catch (Exception)
            {
                webBrowser1.Navigate("https://ya.ru");
                MessageBox.Show("Неверно введено имя сайта");
            }
            
        }

        private void сохранитьНаДискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("browserHistory.txt", (Convert.ToString(historyListBox.Items[historyListBox.SelectedIndex]+$"\t{DateTime.Now}\n")));
        }

        private void FixButton_Click(object sender, EventArgs e)
        {
            try
            {
                zakladkyListBox.Items.Add(historyListBox.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Необходимо выделить вкладку");
            }
        }

        private void GoOnFixPage(object sender, EventArgs e)
        {
            webBrowser1.Navigate(zakladkyListBox.Text );
        }

        private void удалитьИзЗакладокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zakladkyListBox.Items.RemoveAt(zakladkyListBox.SelectedIndex);
        }

        private void удалитьИзИсторииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyListBox.Items.RemoveAt(historyListBox.SelectedIndex);
        }

        private void очиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены, что хотите очистить всю историю?";
            string mesBox = "Очистка истории браузера";
            var result = MessageBox.Show(message, mesBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                historyListBox.Items.Clear();
                
            }
            else
            {
            }

        }
       
    }
}
