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
    public partial class BoardAccessHome : Form
    {
        public BoardAccessHome()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmd2;

        private void btnCashAtHand_Click(object sender, EventArgs e)
        {
            try
            {
                TotalCashAtHand obj = new TotalCashAtHand();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnTotExp_Click(object sender, EventArgs e)
        {
            try
            {
                BoardTotExpenses obj = new BoardTotExpenses();
                obj.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void BoardAccessHome_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-9BT8OBG;Initial Catalog=Nibmfinaltest;Integrated Security=True");
        }

        private void btnCashInHand_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string r, i;
                r = "";
                i = "";
                cmd = new SqlCommand("select sum (amount) from advertisements", con);
                SqlDataReader dx = cmd.ExecuteReader();


                while (dx.Read())
                {
                    i = dx.GetValue(0).ToString();
                }
                con.Close();
                con.Open();

                cmd2 = new SqlCommand("select sum (amount_withdrawn) from expenses", con);
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {

                    r = dr.GetValue(0).ToString();
                }
                con.Close();
                int x = Convert.ToInt32(i) - Convert.ToInt32(r);
                txtBoxCashInHand.Text = x.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            

        }
            }
        }
    

