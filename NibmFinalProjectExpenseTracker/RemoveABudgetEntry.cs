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
using System.Linq.Expressions;

namespace NibmFinalProjectExpenseTracker
{
    public partial class RemoveABudgetEntry : Form
    {
        public RemoveABudgetEntry()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (String.IsNullOrEmpty(comboBoxadtypeDelBudg.Text) || String.IsNullOrEmpty(txtDelBudgName.Text) || String.IsNullOrEmpty(txtEntDel.Text) || String.IsNullOrEmpty(comboBoxDelRank.Text))
                {
                    MessageBox.Show("No Fields Can Be Empty", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {

                    cmd = new SqlCommand("Delete from advertisements where pb_rank='" + comboBoxDelRank.Text + "' and member_name ='" + txtDelBudgName.Text + "' and Advert_Type='" + comboBoxadtypeDelBudg.Text + "' and AdEntity='" + txtEntDel.Text + "' and amount='" + txtamtDelBudg.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        MessageBox.Show("Advertisement Entry Cannot Be Deleted, or does not exist", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Advertisement Entry Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                con.Close();

            }
           catch (Exception)
            {
                MessageBox.Show("An Unknown Error Occured Please Retry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        
       

        }

        private void RemoveABudgetEntry_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");
        }

        private void comboBoxadtypeDelBudg_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxadtypeDelBudg.SelectedIndex == 0)
            {
                txtamtDelBudg.Text = "1500";

            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 1)
            {
                txtamtDelBudg.Text = "2000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 2)
            {
                txtamtDelBudg.Text = "5000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 3)
            {
                txtamtDelBudg.Text = "5000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 4)
            {
                txtamtDelBudg.Text = "7000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 5)
            {
                txtamtDelBudg.Text = "12000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 6)
            {
                txtamtDelBudg.Text = "40000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 7)
            {
                txtamtDelBudg.Text = "80000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 8)
            {
                txtamtDelBudg.Text = "150000";
            }
            else if (comboBoxadtypeDelBudg.SelectedIndex == 9)
            {
                txtamtDelBudg.Text = "300000";
            }
        }

        private void btnRemBudgetClr_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxadtypeDelBudg.SelectedIndex = -1;
                comboBoxDelRank.SelectedIndex = -1;
                txtamtDelBudg.Clear();
                txtDelBudgName.Clear();
                txtEntDel.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("An Unknown Error Occured Please Retry", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnRemBudgetExit_Click(object sender, EventArgs e)
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
