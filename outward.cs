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
   
    public partial class outward : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public outward()
        {
            InitializeComponent();
        }

        private void outward_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akimssDataSet.out_register' table. You can move, or remove it, as needed.
            this.out_registerTableAdapter.Fill(this.akimssDataSet.out_register);

            SqlConnection con = new SqlConnection("Data source=LAPTOP-GR01H1AK;Initial catalog=akimss;integrated security=true");
            SqlCommand cm = new SqlCommand("select sub_id,sub_desc from subject", con);
            SqlDataAdapter d = new SqlDataAdapter();
            d.SelectCommand = cm;
            DataTable table2 = new DataTable();
            d.Fill(table2);


            DataRow itemrow1 = table2.NewRow();
            itemrow1[1] = "Select Subject";
            table2.Rows.InsertAt(itemrow1, 0);


            cmbout_sdesc.DataSource = table2;
            cmbout_sdesc.DisplayMember = "sub_desc";
            cmbout_sdesc.ValueMember = "sub_id";




            SqlConnection conn = new SqlConnection("Data source=LAPTOP-GR01H1AK;Initial catalog=akimss;integrated security=true");
            SqlCommand cmd = new SqlCommand("select f_id,f_name from faculty", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow = table1.NewRow();
            itemrow[1] = "Select Given By";
            table1.Rows.InsertAt(itemrow, 0);

            cmbout_atofaculty.DataSource = table1;
            cmbout_atofaculty.DisplayMember = "f_name";
            cmbout_atofaculty.ValueMember = "f_id";


            cmbout_ay.SelectedIndex = 6;
            cmbmode.SelectedIndex = 0;

            filldatagrid();
        }
        private void filldatagrid()
        {

            cn = new
           SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string sql = "select * from out_register";
            cmd = new SqlCommand(sql, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvoutward.DataSource = dt;
            dgvoutward.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);

            cn.Close();
            lbltotal.Text = dt.Rows.Count.ToString();
        }

        private void clearall()
        {
            lbl_out_no.Text = "";
            dtpout_date.ResetText();
            txtout_time.Text = "";
            txtout_add.Text = "";
            txtout_wsent.Text = "";
            txtout_lno.Text = "";
            dtpout_ldate.ResetText();
            cmbout_sdesc.Text = "Select Subject";
            lbl_sub_id.Text = "";
            dtpout_adate.ResetText();
            txtout_atime.Text = "";
            cmbout_atofaculty.Text = "Select Given By";
            lbl_f_id.Text = "";
            cmbmode.Text = "Select Mode";
            txtout_city.Text = "";
            cmbout_ay.Text = "2022-2023";
          




        }
        private void txtout_aother_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btn_addsub_Click(object sender, EventArgs e)
        {
            Add_Subject f1 = new Add_Subject();
            f1.Show();
            Visible = false;
        }

        private void btn_addper_Click(object sender, EventArgs e)
        {
            Add_Assigned_To a = new Add_Assigned_To();
            a.Show();
            Visible = false;
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
                    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "insert into out_register(out_date,out_time,out_add,out_wsen,out_lno,out_ldate,out_dtsent,sub_desc,sub_id,out_adate,out_atime,out_ato,f_id,out_mode,out_city,academic_yr) values(@lblout_d,@lblout_t,@lblout_add,@lblout_wsent,@lblout_lno,@lblout_ldate,@lblout_dtsent,@lblouts_desc,@lblsub_id,@lblout_adate,@lblout_atime,@lblout_ato,@lblf_id,@lblout_mode,@lblout_city,@lblout_ay)";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblout_d", dtpout_date.Value);
                    cmd.Parameters.AddWithValue("@lblout_t", txtout_time.Text);
                    cmd.Parameters.AddWithValue("@lblout_add", txtout_add.Text);
                    cmd.Parameters.AddWithValue("@lblout_wsent", txtout_wsent.Text);
                    cmd.Parameters.AddWithValue("@lblout_lno", txtout_lno.Text);
                    cmd.Parameters.AddWithValue("@lblout_ldate", dtpout_ldate.Value);
                    cmd.Parameters.AddWithValue("@lblout_dtsent", dtpout_dtsent.Value);
                    cmd.Parameters.AddWithValue("@lblouts_desc", cmbout_sdesc.Text);
                    cmd.Parameters.AddWithValue("@lblsub_id", lbl_sub_id.Text);
                    cmd.Parameters.AddWithValue("lblout_adate", dtpout_adate.Value);
                    cmd.Parameters.AddWithValue("@lblout_atime", txtout_atime.Text);
                    cmd.Parameters.AddWithValue("@lblout_ato", cmbout_atofaculty.Text);
                    cmd.Parameters.AddWithValue("@lblf_id", lbl_f_id.Text);
                    cmd.Parameters.AddWithValue("@lblout_mode", cmbmode.Text);
                    cmd.Parameters.AddWithValue("@lblout_city", txtout_city.Text);
                    cmd.Parameters.AddWithValue("@lblout_ay", cmbout_ay.Text);
                    int r;
                    cn.Open();
                    r = cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records are Saved" + r, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldatagrid();
                    clearall();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtout_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblin_aother_Click(object sender, EventArgs e)
        {

        }

        private void lblout_t_Click(object sender, EventArgs e)
        {

        }

        private void txtout_lno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new
               SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string sql = "delete from out_register where out_no=@lblout_no ";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@lblout_no", lbl_out_no.Text);
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

        private void dgvinward_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvinward_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_out_no.Text = dgvoutward.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpout_date.Value = Convert.ToDateTime(dgvoutward.Rows[e.RowIndex].Cells[1].Value);
            txtout_time.Text = dgvoutward.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtout_add.Text = dgvoutward.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtout_wsent.Text = dgvoutward.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtout_lno.Text = dgvoutward.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpout_ldate.Value = Convert.ToDateTime(dgvoutward.Rows[e.RowIndex].Cells[6].Value);
            dtpout_dtsent.Value = Convert.ToDateTime(dgvoutward.Rows[e.RowIndex].Cells[7].Value);
            cmbout_sdesc.Text = dgvoutward.Rows[e.RowIndex].Cells[8].Value.ToString();
            //lbl_sub_id.Text = dgvoutward.Rows[e.RowIndex].Cells[9].Value.ToString();
            dtpout_adate.Value = Convert.ToDateTime(dgvoutward.Rows[e.RowIndex].Cells[9].Value);
            txtout_atime.Text = dgvoutward.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmbout_atofaculty.Text = dgvoutward.Rows[e.RowIndex].Cells[11].Value.ToString();
            //lbl_f_id.Text = dgvoutward.Rows[e.RowIndex].Cells[13].Value.ToString();
            cmbmode.Text = dgvoutward.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtout_city.Text = dgvoutward.Rows[e.RowIndex].Cells[13].Value.ToString();
            cmbout_ay.Text = dgvoutward.Rows[e.RowIndex].Cells[14].Value.ToString();
           
          
            
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
                    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "update out_register set out_date=@lblout_d,out_time=@lblout_t,out_add=@lblout_add,out_wsen=@lblout_wsent,out_lno=@lblout_lno,out_ldate=@lblout_ldate,out_dtsent=@lblout_dtsent,sub_desc=@lblouts_desc,sub_id=@lblsub_id,out_adate=@lblout_adate,out_atime=@lblout_atime,out_ato=@lblout_ato,f_id=@lblf_id,out_mode=@lblout_mode,out_city=@lblout_city,academic_yr=@lblout_ay where out_no=@lblout_no";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblout_d", dtpout_date.Value);
                    cmd.Parameters.AddWithValue("@lblout_t", txtout_time.Text);
                    cmd.Parameters.AddWithValue("@lblout_add", txtout_add.Text);
                    cmd.Parameters.AddWithValue("@lblout_wsent", txtout_wsent.Text);
                    cmd.Parameters.AddWithValue("@lblout_lno", txtout_lno.Text);
                    cmd.Parameters.AddWithValue("@lblout_ldate", dtpout_ldate.Value);
                    cmd.Parameters.AddWithValue("@lblout_dtsent", dtpout_dtsent.Value);
                    cmd.Parameters.AddWithValue("@lblouts_desc", cmbout_sdesc.Text);
                    cmd.Parameters.AddWithValue("@lblsub_id", lbl_sub_id.Text);
                    cmd.Parameters.AddWithValue("lblout_adate", dtpout_adate.Value);
                    cmd.Parameters.AddWithValue("@lblout_atime", txtout_atime.Text);
                    cmd.Parameters.AddWithValue("@lblout_ato", cmbout_atofaculty.Text);
                    cmd.Parameters.AddWithValue("@lblf_id", lbl_f_id.Text);
                    cmd.Parameters.AddWithValue("@lblout_mode", cmbmode.Text);
                    cmd.Parameters.AddWithValue("@lblout_city", txtout_city.Text);
                    cmd.Parameters.AddWithValue("@lblout_no", lbl_out_no.Text);
                    cmd.Parameters.AddWithValue("@lblout_ay", cmbout_ay.Text);


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

        private void dtpout_ldate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblout_lno_Click(object sender, EventArgs e)
        {

        }

        private void lblout_wsent_Click(object sender, EventArgs e)
        {

        }
        private bool validate ()
        {
            if (txtout_time.Text == "")
            {
                MessageBox.Show("Please Enter Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtout_time.Focus();
                return false;
            }
            else if (txtout_add.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtout_add.Focus();
                return false;
            }
            else if (txtout_wsent.Text == "")
            {
                MessageBox.Show("Please Enter To Whom We Sending", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtout_wsent.Focus();
                return false;
            }
            else if (txtout_lno.Text == "")
            {
                MessageBox.Show("Please Enter Letter No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtout_lno.Focus();
                return false;
            }
            else if (cmbout_sdesc.Text == "Select Subject")
            {
                MessageBox.Show("Please Select Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbout_sdesc.Focus();
                return false;
            }
            else if (txtout_atime.Text == "")
            {
                MessageBox.Show("Please Enter Assigned Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtout_atime.Focus();
                return false;
            }
            else if (cmbout_atofaculty.Text == "Select Given By")
            {
                MessageBox.Show("Please Select Given By", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbout_atofaculty.Focus();
                return false;
            }
            else if (cmbmode.Text == "Select Mode")
            {
                MessageBox.Show("Please Enter Mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbmode.Focus();
                return false;
            }
            else if (txtout_city.Text == "")
            {
                MessageBox.Show("Enter City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtout_city.Focus();
                return false;
            }
            else if (cmbout_ay.Text == "Select Academic Year")
            {
                MessageBox.Show("Please Select Academic Year","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cmbout_ay.Focus();
                return false;
            }
            return true;
        }

        private void cmbout_sdesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbout_sdesc_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_sub_id.Text = cmbout_sdesc.SelectedValue.ToString();
        }

        private void cmbout_atofaculty_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_f_id.Text = cmbout_atofaculty.SelectedValue.ToString();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            Main_Menu m = new Main_Menu();
            m.Show();
            Visible = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblf_id_Click(object sender, EventArgs e)
        {

        }

        private void dtpout_adate_CloseUp(object sender, EventArgs e)
        {
            DateTime outdate = Convert.ToDateTime(dtpout_date.Text);
            DateTime adate = Convert.ToDateTime(dtpout_adate.Text);
            if (adate <= outdate)
            {

            }
            else
            {
                MessageBox.Show("Assigned Date Must Be Smaller Than Outward Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpout_adate.ResetText();
            }
            DateTime sentdate = Convert.ToDateTime(dtpout_dtsent.Text);
            DateTime asdate = Convert.ToDateTime(dtpout_adate.Text);
            if (asdate <= sentdate)
            {

            }
            else
            {
                MessageBox.Show("Assigned Date Must Be Smaller Than Date Of Sent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpout_adate.ResetText();
            }
            DateTime ldate = Convert.ToDateTime(dtpout_ldate.Text);
            DateTime assdate = Convert.ToDateTime(dtpout_adate.Text);
            if (ldate <= assdate)
            {

            }
            else
            {
                MessageBox.Show("Assigned Date Must Be Greater Than Letter Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpout_adate.ResetText();
            }
        }

        private void dtpout_dtsent_CloseUp(object sender, EventArgs e)
        {
            DateTime outdate = Convert.ToDateTime(dtpout_date.Text);
            DateTime sentdate = Convert.ToDateTime(dtpout_dtsent.Text);
            if (outdate <= sentdate)
            {

            }
            else
            {
                MessageBox.Show("Date Of Sent Must Be Greater Than Outward Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpout_dtsent.ResetText();
            }
           
        }

        private void dtpout_ldate_CloseUp(object sender, EventArgs e)
        {
            DateTime outdate = Convert.ToDateTime(dtpout_date.Text);
            DateTime ldate = Convert.ToDateTime(dtpout_ldate.Text);
            if (ldate <= outdate)
            {

            }
            else
            {
                MessageBox.Show("Letter Date Must Be Smaller Than Outward Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpout_ldate.ResetText();
            }
        }

        private void lbl_sub_id_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 157);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 109);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 93);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 56);
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblout_no_Click(object sender, EventArgs e)
        {

        }

        private void lblout_d_Click(object sender, EventArgs e)
        {

        }

        private void lblout_add_Click(object sender, EventArgs e)
        {

        }

        private void txtout_wsent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtout_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtout_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpout_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_out_no_Click(object sender, EventArgs e)
        {

        }

        private void lblout_ay_Click(object sender, EventArgs e)
        {

        }

        private void inwardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inward i = new Inward();
            i.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.ShowDialog();
        }
    }
}
