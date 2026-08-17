using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NibmFinalProjectExpenseTracker
{
    public partial class ExpenseAdd : Form
    {
        public ExpenseAdd()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void ExpenseAdd_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");
        }

        private void btnExpenseenter_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                if (string.IsNullOrEmpty(comboBoxExpenseComittee.Text) || string.IsNullOrEmpty(comboBoxRank.Text) || string.IsNullOrEmpty(txtapprv.Text) || string.IsNullOrEmpty(txtexpamt.Text) || string.IsNullOrEmpty(txtExpName.Text) || string.IsNullOrEmpty(txtexpty.Text) || string.IsNullOrEmpty(txtRecnum.Text))
                {
                    MessageBox.Show("No Fields Can Be Empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {

                    cmd = new SqlCommand("Insert into expenses values ('" + comboBoxRank.Text + "','" + comboBoxExpenseComittee.Text + "','" + txtExpName.Text + "','" + txtexpty.Text + "','" + txtRecnum.Text + "','" + txtexpamt.Text + "','" + txtapprv.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        MessageBox.Show("Expense Cannot Be Recorded", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Expense Recorded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                con.Close();


                
            }
                      catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxRank.SelectedIndex = -1;
                comboBoxExpenseComittee.SelectedIndex = -1;
                txtapprv.Clear();
                txtexpamt.Clear();
                txtExpName.Clear();
                txtexpty.Clear();
                txtRecnum.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnFormal_Click(object sender, EventArgs e)
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
