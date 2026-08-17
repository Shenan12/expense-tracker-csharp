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
    public partial class BudgetUpdater : Form
    {
        public BudgetUpdater()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd; 
        private void BudgetUpdater_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                if (string.IsNullOrEmpty(comboBoxadtype.Text) || string.IsNullOrEmpty(comboBoxRank.Text) || string.IsNullOrEmpty(txtadName.Text) || string.IsNullOrEmpty(txtamt.Text) || string.IsNullOrEmpty(txtCollector.Text) || string.IsNullOrEmpty(txtEntity.Text))
                {
                    MessageBox.Show("No Fields Can Be Empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

                else
                {
                    cmd = new SqlCommand("Insert into advertisements values ('" + comboBoxRank.Text + "','" + txtadName.Text + "','" + comboBoxadtype.Text + "','" + txtEntity.Text + "','" + txtamt.Text + "','" + txtCollector.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        MessageBox.Show("Advert Cannot Be Recorded, Please Re-Check Your Entry As No fields Can Be left Empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Advert Recorded Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("An Unknown Error Occured Please Retry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void comboBoxadtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxadtype.SelectedIndex == 0)
            {
                txtamt.Text = "1500";

            }
            else if (comboBoxadtype.SelectedIndex == 1)
            {
                txtamt.Text = "2000";
            }
            else if (comboBoxadtype.SelectedIndex == 2)
            {
                txtamt.Text = "5000";
            }
            else if (comboBoxadtype.SelectedIndex == 3)
            {
                txtamt.Text = "5000";
            }
            else if (comboBoxadtype.SelectedIndex == 4)
            {
                txtamt.Text = "7000";
            }
            else if (comboBoxadtype.SelectedIndex == 5)
            {
                txtamt.Text = "12000";
            }
            else if (comboBoxadtype.SelectedIndex == 6)
            {
                txtamt.Text = "40000";
            }
            else if (comboBoxadtype.SelectedIndex == 7)
            {
                txtamt.Text = "80000";
            }
            else if (comboBoxadtype.SelectedIndex == 8)
            {
                txtamt.Text = "150000";
            }
            else if (comboBoxadtype.SelectedIndex == 9)
            {
                txtamt.Text = "300000";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxadtype.SelectedIndex = -1;
                comboBoxRank.SelectedIndex = -1;
                txtadName.Clear();
                txtamt.Clear();
                txtCollector.Clear();
                txtEntity.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("An Unknown Error Occured Please Retry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An Unknown Error Occured Please Retry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
