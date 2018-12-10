using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab08Lib;

namespace Lab10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gvSubs.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Имя";
            gvSubs.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SecondName";
            column.Name = "Фамилия";
            gvSubs.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PhoneNum";
            column.Name = "Номер телефона";
            gvSubs.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Страна";
            gvSubs.Columns.Add(column);
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Cost";
                column.Name = "Стоимость пакета услуг";
                gvSubs.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasCost";
            column.Name = "Оплата";
            column.Width = 60;

            gvSubs.Columns.Add(column);
            bindSrcSubs.Add(new Sub("Никита", "Ковальчук", "(095)092-3292", "Украина", 175, true));
            EventArgs args = new EventArgs();
            OnResize(args);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Sub sub = new Sub();
            SubForm ft = new SubForm(sub);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcSubs.Add(sub);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sub sub = (Sub)bindSrcSubs.List[bindSrcSubs.Position];
            SubForm ft = new SubForm(sub);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcSubs.List[bindSrcSubs.Position] = sub;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcSubs.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcSubs.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
