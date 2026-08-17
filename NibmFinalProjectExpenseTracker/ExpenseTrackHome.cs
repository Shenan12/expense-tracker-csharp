using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NibmFinalProjectExpenseTracker
{
    public partial class ExpenseTrackHome : Form
    {
        public ExpenseTrackHome()
        {
            InitializeComponent();
        }

        private void btnFormal_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseAdd obj = new ExpenseAdd();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveExpense_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseDel obj = new ExpenseDel();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
