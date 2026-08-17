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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            try
            {
                AdvertsHome obj = new AdvertsHome();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseTrackHome obj = new ExpenseTrackHome();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            try
            {
                BoardAccessHome obj = new BoardAccessHome();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
