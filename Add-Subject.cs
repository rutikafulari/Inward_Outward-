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
    public partial class Add_Subject : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public Add_Subject()
        {
            InitializeComponent();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            
        }
        private void filldatagrid()
        {

            cn = new
           SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string sql = "select * from subject";
            cmd = new SqlCommand(sql, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvsubject.DataSource = dt;
            dgvsubject.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            cn.Close();
        }

        private void Add_Subject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akimssDataSet.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.akimssDataSet.subject);
            filldatagrid();
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
                    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "insert into subject(sub_desc) values (@lbls_desc)";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lbls_desc", txts_desc.Text);

                    int r;
                    cn.Open();
                    r = cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records are saved" + r, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldatagrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void clearall()
        {
            lbl_s_id.Text = "";
            txts_desc.Text = "";
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new
               SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string sql = "delete from subject where sub_id=@lbls_id ";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@lbls_id", lbl_s_id.Text);
                int r;
                cn.Open();
                r = cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Records Deleted are " + r, "Deleted..", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                filldatagrid();
                clearall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void dgvsubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_s_id.Text = dgvsubject.Rows[e.RowIndex].Cells[0].Value.ToString();
            txts_desc.Text = dgvsubject.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "update subject set sub_desc=@lbls_desc where sub_id=@lbls_id";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lbls_desc", txts_desc.Text);
                    cmd.Parameters.AddWithValue("@lbls_id", lbl_s_id.Text);
                    int r;
                    cn.Open();
                    r = cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records Updated are " + r, "Updated..", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    filldatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnout_Click(object sender, EventArgs e)
        {
           
        }

        private bool validate()
        {
            if (txts_desc.Text == "")
            {
                MessageBox.Show("Please Enter Subject Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txts_desc.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0,430, 115);
        }

        private void inwardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inward i = new Inward();
            i.Show();
            this.Hide();
        }

        private void outwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outward o = new outward();
            o.Show();
            Visible = false;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.ShowDialog();
        }
    }
}
