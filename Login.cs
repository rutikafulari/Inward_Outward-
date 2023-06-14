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
using System.Configuration;


namespace Inword_Outword
{
    public partial class Login : Form
    {
        SqlConnection cn;
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        private void btns_Click(object sender, EventArgs e)
        {
          
            
            if (validate())
            {
                try
                {
                    cn = new
    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "select * from admin where uname=@lblu and password=@lblp";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblu", txtu.Text);
                    cmd.Parameters.AddWithValue("@lblp", txtp.Text);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Login Successful !","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);


                        Main_Menu m = new Main_Menu();
                        m.Show();
                        Visible = false;


                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful !","Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        txtu.SelectAll();
                        txtu.Focus();
                        cn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked==true)
            {
                txtp.UseSystemPasswordChar = false;
            }
            else
            {
                txtp.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
            //lblp.BackColor = Color.Transparent;
            //lblu.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            checkBoxpass.BackColor = Color.Transparent;
            
           
        }
        private bool validate ()
        {
            if (txtu.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtu.Focus();
                return false;
            }
            else if (txtp.Text =="")
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtp.Focus();
                return false;
            }
            return true;
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtp_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

    }
}
