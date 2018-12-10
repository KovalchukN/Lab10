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
    public partial class SubForm : Form
    {
        private Sub TheSub;
        internal SubForm(Sub t)
        {

            TheSub = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {


            TheSub.Name = tbName.Text.Trim();
            TheSub.SecondName = tbSecondName.Text.Trim();
            
                TheSub.PhoneNum = mtbPhoneNum.Text.Trim();
            
                TheSub.Country = tbCountry.Text.Trim();
            try
            {
                TheSub.Cost = int.Parse(tbCost.Text.Trim());
            }
            catch (InvalidCostException)
            {
                MessageBox.Show("Стоимость не может быть меньше 1 и больше 300", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TheSub.HasCost = chbHasCost.Checked;
            DialogResult = DialogResult.OK;
            
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fSub_Load(object sender, EventArgs e)
        {
            if (TheSub != null)
            {
                tbName.Text = TheSub.Name;
                tbSecondName.Text = TheSub.SecondName;
                mtbPhoneNum.Text = TheSub.PhoneNum;
                tbCountry.Text = TheSub.Country;
                tbCost.Text = TheSub.Cost.ToString();
                chbHasCost.Checked = TheSub.HasCost;
            }
        }



        private void tbCost_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCost.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCost.Text = tbCost.Text.Remove(tbCost.Text.Length - 1);
            }
        }

        private void mtbPhoneNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mtbPhoneNum.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbPhoneNum.Text = mtbPhoneNum.Text.Remove(mtbPhoneNum.Text.Length - 1);
            }

        }


    }
}
