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
    public partial class BoardTotExpenses : Form
    {
        public BoardTotExpenses()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        private void BoardTotExpenses_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");
        }

        private void btnAllExp_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                da = new SqlDataAdapter("select * from expenses", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnDupli_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                


                {
                    cmd = new SqlCommand("Delete from expenses where ExpID='" + txtPrimaryKey.Text + "' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                    {
                        MessageBox.Show("Duplicate Entry Cannot Be Deleted", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Duplicate Entry Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnBatchBudget_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            { 
           
            if (string.IsNullOrEmpty(comboBoxExpDelComit.Text))
            {
                MessageBox.Show("Please Select A Comittee", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                
                {
                    da = new SqlDataAdapter("select * from expenses where committee='" + comboBoxExpDelComit.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    cmd = new SqlCommand("select sum (amount_withdrawn) from expenses where committee='" + comboBoxExpDelComit.Text + "'", con);
                    SqlDataReader dx = cmd.ExecuteReader();
                    while (dx.Read())
                    {
                        if (string.IsNullOrEmpty(dx.GetValue(0).ToString()))
                        {
                            MessageBox.Show("The Batch Has Not Contributed Anything Yet", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            textBoxanswerDisplay.Text = dx.GetValue(0).ToString();
                        }
                    }
                    txtExpDelName.Clear();
                        comboBoxExpDelRank.SelectedIndex = -1; 
                }




            }
               
            }

         catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void btnSecificMemberBudget_Click(object sender, EventArgs e)
        {
            con.Open();
            
            {
                if (string.IsNullOrEmpty(comboBoxExpDelRank.Text) || string.IsNullOrEmpty(txtExpDelName.Text))
                {
                    MessageBox.Show("Please Select A Batch Or Please Enter A Valid Name", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else

                try
                {
                    cmd = new SqlCommand("select sum (amount_withdrawn) from expenses where pb_rank='" + comboBoxExpDelRank.Text + "' and Member_Name='" + txtExpDelName.Text + "'", con);
                    da = new SqlDataAdapter("select * from expenses where pb_rank='" + comboBoxExpDelRank.Text + "' and Member_Name='" + txtExpDelName.Text + "'", con);
                    DataTable df = new DataTable();
                    da.Fill(df);
                    dataGridView1.DataSource = df;

                    SqlDataReader dx = cmd.ExecuteReader();
                    while (dx.Read())

                    {
                        if (string.IsNullOrEmpty(dx.GetValue(0).ToString()))
                        {
                            MessageBox.Show("Please Enter A Valid Name or Member Has Not Contributed Anything Yet", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            textBoxanswerDisplay.Text = dx.GetValue(0).ToString();
                        }
                    }

                }
                    catch (Exception)
                    {
                        MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

            }
           
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("select sum (amount_withdrawn) from expenses", con);
                SqlDataReader dx = cmd.ExecuteReader();
                while (dx.Read())
                {
                    if (string.IsNullOrEmpty(dx.GetValue(0).ToString()))
                    {
                        MessageBox.Show("No Cash Outflow Yet", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        textBoxanswerDisplay.Text = dx.GetValue(0).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            con.Close();
        }
    }
}
