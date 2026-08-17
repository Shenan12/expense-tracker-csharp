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
using System.Data.Common;

namespace NibmFinalProjectExpenseTracker
{
    public partial class TotalCashAtHand : Form
    {
        public TotalCashAtHand()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd; 
        SqlDataAdapter da;
        private void TotalCashAtHand_Load(object sender, EventArgs e)
        {
            con= new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("select sum (amount) from advertisements", con);
                SqlDataReader dx= cmd.ExecuteReader();
                while (dx.Read())
                {
                    if (string.IsNullOrEmpty(dx.GetValue(0).ToString()))
                    {
                        MessageBox.Show("No Cash Inflow Yet", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

        private void btnSecificMemberBudget_Click(object sender, EventArgs e)
        {
            con.Open();
            string r;
            r = "";
            try 
            {
                if (string.IsNullOrEmpty(comboBoxExpDelRank.Text) || string.IsNullOrEmpty(txtExpDelName.Text))
                {
                    MessageBox.Show("Please Select A Batch Or Please Enter A Valid Name", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else


                 {
                    cmd = new SqlCommand("select sum (amount) from advertisements where pb_rank='" + comboBoxExpDelRank.Text + "' and Member_Name='" + txtExpDelName.Text + "'", con);
                    da = new SqlDataAdapter("select * from advertisements where pb_rank='" + comboBoxExpDelRank.Text + "' and Member_Name='" + txtExpDelName.Text + "'", con);
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
                            r = dx.GetValue(0).ToString();
                            Convert.ToInt32(r);
                            int x; x = 0;
                            if(comboBoxExpDelRank.SelectedIndex == 0)
                            {
                                x = 8000 - Convert.ToInt32(r);
                                if (x>0)
                                {
                                    string p = Convert.ToString(x);
                                    textBox1.Text ="Rs." + x + " To Be Covered";   
                                }
                                else if (x<=0)
                                {
                                    textBox1.Text = "Budget Covered";
                                }

                            }

                            if (comboBoxExpDelRank.SelectedIndex == 1)
                            {
                                x = 16000 - Convert.ToInt32(r);
                                if (x > 0)
                                {
                                    string p = Convert.ToString(x);
                                    textBox1.Text = "Rs." + x + " To Be Covered";
                                }
                                else if (x <= 0)
                                {
                                    textBox1.Text = "Budget Covered";
                                }
                            }

                            if (comboBoxExpDelRank.SelectedIndex == 2)
                            {
                                x = 25000 - Convert.ToInt32(r);
                                if (x > 0)
                                {
                                    string p = Convert.ToString(x);
                                    textBox1.Text = "Rs." + x + " To Be Covered";
                                }
                                else if (x <= 0)
                                {
                                    textBox1.Text = "Budget Covered";
                                }
                            }

                            if (comboBoxExpDelRank.SelectedIndex == 3)
                            {
                                textBox1.Text = "Covered";
                            }
                        }
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
                if (string.IsNullOrEmpty(comboBoxExpDelRank.Text))
                {
                    MessageBox.Show("Please Select A Batch", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {

                    {
                        da = new SqlDataAdapter("select * from advertisements where pb_rank='" + comboBoxExpDelRank.Text + "'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        cmd = new SqlCommand("select sum (amount) from advertisements where pb_rank='" + comboBoxExpDelRank.Text + "'", con);
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

                    }

                }
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
                    cmd = new SqlCommand("Delete from Advertisements where advertID='"+txtPrimaryKey.Text+"' ", con);
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

        private void btnAllAdvertisem_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                da = new SqlDataAdapter("select * from advertisements", con);
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
    }
}
