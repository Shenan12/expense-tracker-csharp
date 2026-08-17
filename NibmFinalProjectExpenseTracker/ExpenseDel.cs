using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NibmFinalProjectExpenseTracker
{
    public partial class ExpenseDel : Form
    {
        public ExpenseDel()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection conn; 
        private void ExpenseDel_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (string.IsNullOrEmpty(comboBoxExpDelComit.Text) || string.IsNullOrEmpty(comboBoxExpDelRank.Text) || string.IsNullOrEmpty(txtDelExpamt.Text) || string.IsNullOrEmpty(txtExpDelName.Text) || string.IsNullOrEmpty(txtExpDelRecnum.Text))
                {
                    MessageBox.Show("No Fields Can Be Empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Delete from expenses where pb_rank='" + comboBoxExpDelRank.Text + "' and Member_Name ='" + txtExpDelName.Text + "' and committee='" + comboBoxExpDelComit.Text + "' and Reciept_Number='" + txtExpDelRecnum.Text + "' and amount_withdrawn='" + txtDelExpamt.Text + "'", conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        MessageBox.Show("Advertisement Entry Cannot Be Deleted", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Advertisement Entry Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExpenseDelClr_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxExpDelRank.SelectedIndex = -1;
                comboBoxExpDelComit.SelectedIndex = -1;
                txtDelExpamt.Clear();
                txtExpDelName.Clear();
                txtExpDelRecnum.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnexpenseDelExit_Click(object sender, EventArgs e)
        {
            try 
            {
            this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
