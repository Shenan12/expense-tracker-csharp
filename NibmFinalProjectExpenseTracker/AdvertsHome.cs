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
    public partial class AdvertsHome : Form
    {
        public AdvertsHome()
        {
            InitializeComponent();
        }

        private void btnAddBudget_Click(object sender, EventArgs e)
        { try
            {
                BudgetUpdater obj = new BudgetUpdater();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

           
        }

        private void btnRemoveBudget_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveABudgetEntry obj = new RemoveABudgetEntry();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
