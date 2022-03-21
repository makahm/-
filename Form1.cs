using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавить что-то!", "Действие!");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить что-то!", "Действие!");
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавить что-то через меню!", "Действие!");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить что-то через меню!", "Действие!");
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вернуть некуда!", "Внимание!");
        }

        private void совсемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
