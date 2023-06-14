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
    public partial class Inward : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public Inward()
        {
            InitializeComponent();
        }

        private void lbl_fid_Click(object sender, EventArgs e)
        {

        }

        private void Inward_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akimssDataSet.in_register' table. You can move, or remove it, as needed.
            //this.in_registerTableAdapter.Fill(this.akimssDataSet.in_register);
            SqlConnection conn = new SqlConnection("Data source=LAPTOP-GR01H1AK;Initial catalog=akimss;integrated security=true");
            SqlCommand cmd = new SqlCommand("select f_id,f_name from faculty", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow = table1.NewRow();
            itemrow[1] = "Select Given To";
            table1.Rows.InsertAt(itemrow, 0);

            cmbin_atofaculty.DataSource = table1;
            cmbin_atofaculty.DisplayMember = "f_name";
            cmbin_atofaculty.ValueMember = "f_id";




            SqlConnection con = new SqlConnection("Data source=LAPTOP-GR01H1AK;Initial catalog=akimss;integrated security=true");
            SqlCommand cm = new SqlCommand("select sub_id,sub_desc from subject", con);
            SqlDataAdapter d = new SqlDataAdapter();
            d.SelectCommand = cm;
            DataTable table2 = new DataTable();
            d.Fill(table2);


            DataRow itemrow1 = table2.NewRow();
            itemrow1[1] = "Select Subject";
            table2.Rows.InsertAt(itemrow1, 0);


            cmbin_sdesc.DataSource = table2;
            cmbin_sdesc.DisplayMember = "sub_desc";
            cmbin_sdesc.ValueMember = "sub_id";


            cmbin_ay.SelectedIndex = 6;
            cmbmode.SelectedIndex = 0;

            btn_d.Enabled = false;
            btn_u.Enabled = false;
            
            filldatagrid();


            
        }
        private void filldatagrid()
        {
            
            cn = new
          SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string sql = "select * from in_register";
           cmd = new SqlCommand(sql, cn);
           DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvinward.DataSource = dt;
            dgvinward.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            
            cn.Close();
            lbltotal.Text = dt.Rows.Count.ToString();
            
        }
        private void btn_s_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
                    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "insert into in_register(in_date,in_time,in_wrec,in_lno,in_ldate,in_dtrec,sub_desc,sub_id,in_adate,in_atime,a_to,f_id,in_mode,in_city,academic_yr) values(@lblin_d,@lblin_t,@lblin_wrec,@lblin_lno,@lblin_ldate,@lblin_dtrec,@lblins_desc,@lblsub_id,@lblin_adate,@lblin_atime,@lblin_ato,@lblf_id,@lblin_mode,@lblin_city,@lblin_ay)";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblin_d", dtpin_date.Value);
                    cmd.Parameters.AddWithValue("@lblin_t", txtin_time.Text);
                    cmd.Parameters.AddWithValue("@lblin_wrec", txtin_wrec.Text);
                    cmd.Parameters.AddWithValue("@lblin_lno", txtin_lno.Text);
                    cmd.Parameters.AddWithValue("@lblin_ldate", dtpin_ldate.Value);
                    cmd.Parameters.AddWithValue("@lblin_dtrec", dtpin_dtrec.Value);
                    cmd.Parameters.AddWithValue("@lblins_desc", cmbin_sdesc.Text);
                    cmd.Parameters.AddWithValue("@lblsub_id", lbl_sub_id.Text);
                    cmd.Parameters.AddWithValue("lblin_adate", dtpin_adate.Value);
                    cmd.Parameters.AddWithValue("@lblin_atime", txtin_atime.Text);
                    cmd.Parameters.AddWithValue("@lblin_ato", cmbin_atofaculty.Text);
                    cmd.Parameters.AddWithValue("@lblf_id", lbl_f_id.Text);
                    cmd.Parameters.AddWithValue("@lblin_mode", cmbmode.Text);
                    cmd.Parameters.AddWithValue("@lblin_city", txtin_city.Text);
                    cmd.Parameters.AddWithValue("@lblin_ay", cmbin_ay.Text);



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

        private void lblins_desc_Click(object sender, EventArgs e)
        {

        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
                    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "update in_register set in_date=@lblin_d, in_time=@lblin_t,in_wrec=@lblin_wrec,in_lno=@lblin_lno,in_ldate=@lblin_ldate,in_dtrec=@lblin_dtrec,sub_desc=@lblins_desc,sub_id=@lblsub_id,in_adate=@lblin_adate,in_atime=@lblin_atime,a_to=@lblin_ato,f_id=@lblf_id,in_mode=@lblin_mode,in_city=@lblin_city,academic_yr=@lblin_ay where in_no=@lblin_no";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblin_d", dtpin_date.Value);
                    cmd.Parameters.AddWithValue("@lblin_t", txtin_time.Text);
                    cmd.Parameters.AddWithValue("@lblin_wrec", txtin_wrec.Text);
                    cmd.Parameters.AddWithValue("@lblin_lno", txtin_lno.Text);
                    cmd.Parameters.AddWithValue("@lblin_ldate", dtpin_ldate.Value);
                    cmd.Parameters.AddWithValue("@lblin_dtrec", dtpin_dtrec.Value);
                    cmd.Parameters.AddWithValue("@lblins_desc", cmbin_sdesc.Text);
                    cmd.Parameters.AddWithValue("@lblsub_id", lbl_sub_id.Text);
                    cmd.Parameters.AddWithValue("lblin_adate", dtpin_adate.Value);
                    cmd.Parameters.AddWithValue("@lblin_atime", txtin_atime.Text);
                    cmd.Parameters.AddWithValue("@lblin_ato", cmbin_atofaculty.Text);
                    cmd.Parameters.AddWithValue("@lblf_id", lbl_f_id.Text);
                    cmd.Parameters.AddWithValue("@lblin_mode", cmbmode.Text);
                    cmd.Parameters.AddWithValue("@lblin_city", txtin_city.Text);
                    cmd.Parameters.AddWithValue("@lblin_ay", cmbin_ay.Text);
                    cmd.Parameters.AddWithValue("@lblin_no", lbl_in_no.Text);


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

        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new
               SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string sql = "delete from in_register where in_no=@lblin_no ";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@lblin_no", lbl_in_no.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void btn_faculty_Click(object sender, EventArgs e)
        {
            Add_Assigned_To a = new Add_Assigned_To();
            a.Show();
            Visible = false;
        }
        private void clearall()
        {
            lbl_in_no.Text = "";
            dtpin_date.ResetText();
            txtin_time.Text = "";
            txtin_wrec.Text = "";
            txtin_lno.Text = "";
            dtpin_ldate.ResetText();
            dtpin_dtrec.ResetText();
            cmbin_sdesc.Text = "Select Subject";
            dtpin_adate.ResetText();
            txtin_atime.Text = "";
            cmbin_atofaculty.Text = "Select Given To";
            cmbmode.Text = "Select Mode";
            txtin_city.Text = "";
            lbl_f_id.Text = "";
            lbl_sub_id.Text = "";
            cmbin_ay.Text = "2022-2023";
             
             
             
             
        }

        private void btn_in_c_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void dgvinward_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_in_no.Text = dgvinward.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpin_date.Value = Convert.ToDateTime(dgvinward.Rows[e.RowIndex].Cells[1].Value);
            txtin_time.Text = dgvinward.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtin_wrec.Text = dgvinward.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtin_lno.Text = dgvinward.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpin_ldate.Value = Convert.ToDateTime(dgvinward.Rows[e.RowIndex].Cells[5].Value);
            dtpin_dtrec.Value = Convert.ToDateTime(dgvinward.Rows[e.RowIndex].Cells[6].Value);
            cmbin_sdesc.Text = dgvinward.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtpin_adate.Value = Convert.ToDateTime(dgvinward.Rows[e.RowIndex].Cells[8].Value);
            txtin_atime.Text = dgvinward.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbin_atofaculty.Text = dgvinward.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmbmode.Text = dgvinward.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtin_city.Text = dgvinward.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmbin_ay.Text = dgvinward.Rows[e.RowIndex].Cells[13].Value.ToString();
            //lbl_sub_id.Text = dgvinward.Rows[e.RowIndex].Cells[14].Value.ToString();
            //lbl_f_id.Text = dgvinward.Rows[e.RowIndex].Cells[15].Value.ToString();
            
        }

        private void btn_addsub_Click(object sender, EventArgs e)
        {
            Add_Subject f1 = new Add_Subject();
            f1.Show();
            Visible = false;
        }

        private void lblin_d_Click(object sender, EventArgs e)
        {

        }

        private void lblin_t_Click(object sender, EventArgs e)
        {

        }

        private void lblin_wrec_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ino_Click(object sender, EventArgs e)
        {

        }

        private void lblin_lno_Click(object sender, EventArgs e)
        {

        }

        private void lblin_ldate_Click(object sender, EventArgs e)
        {

        }

        private void lblin_dtrec_Click(object sender, EventArgs e)
        {

        }

        private void lblin_adate_Click(object sender, EventArgs e)
        {

        }

        private void lblin_atime_Click(object sender, EventArgs e)
        {

        }

        private void lblin_ato_Click(object sender, EventArgs e)
        {

        }

        private void lblin_mode_Click(object sender, EventArgs e)
        {

        }

        private void lblin_city_Click(object sender, EventArgs e)
        {

        }

        private void cmbin_sdesc_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_sub_id.Text = cmbin_sdesc.SelectedValue.ToString();
        }

        private void cmbin_ato_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_f_id.Text = cmbin_atofaculty.SelectedValue.ToString();
            
        }

        private void txtin_aother_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validate()
        {
            if (txtin_time.Text == "")
            {
                MessageBox.Show("Please Enter Time","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtin_time.Focus();
                return false;

            }
            else if(txtin_wrec.Text=="")
            {
                MessageBox.Show("Please Enter From Whom Received", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtin_wrec.Focus();
                return false;
            }
            else if(txtin_lno.Text=="")
            {
                MessageBox.Show("Please Enter Letter No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtin_lno.Focus();
                return false;
            }
            else if (cmbin_sdesc.Text == "Select Subject")
            {
                MessageBox.Show("Please Select Subject Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbin_sdesc.Focus();
                return false;
            }
            else if (txtin_atime.Text == "")
            {
                MessageBox.Show("Please Enter Given To Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtin_atime.Focus();
                return false;
            }
           
            else if (cmbin_atofaculty.Text == "Select Given To")
            {
                MessageBox.Show("Please Select Given To", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               cmbin_atofaculty.Focus();
                return false;
            }

            else if (cmbmode.Text == "Select Mode")
            {
                MessageBox.Show("Please Select Mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbmode.Focus();
                return false;
            }
            else if (txtin_city.Text == "")
            {
                MessageBox.Show("Please Enter City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtin_city.Focus();
                return false;
            }
            else if (cmbin_ay.Text == "Select Academic Year")
            {
                MessageBox.Show("Please Select Academic Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbin_ay.Focus();
                return false;
            }
            return true;
            
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

        private void button_report_Click(object sender, EventArgs e)
        {
            inreport i = new inreport();
            i.Show();
        }

        private void inwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inreport i = new inreport();
            i.ShowDialog();
        }

        private void dtpin_adate_CloseUp(object sender, EventArgs e)
        {
            DateTime indate = Convert.ToDateTime(dtpin_date.Text);
            DateTime adate = Convert.ToDateTime(dtpin_adate.Text);
            if (indate <= adate)
            {

            }
            else
            {
                MessageBox.Show("Assigned Date Must Be Larger Than Inward Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpin_adate.ResetText();
            }
        }

        private void dtpin_dtrec_CloseUp(object sender, EventArgs e)
        {
            DateTime indate = Convert.ToDateTime(dtpin_date.Text);
            DateTime dtrec = Convert.ToDateTime(dtpin_dtrec.Text);
            
            if (dtrec <= indate )
            {

            }
            else
            {
                MessageBox.Show("Date Of Receipt Must Be Smaller Than Inward Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpin_dtrec.ResetText();
            }
            DateTime recdate = Convert.ToDateTime(dtpin_dtrec.Text);
            DateTime ldate = Convert.ToDateTime(dtpin_ldate.Text);
            if (ldate <= recdate)
            {

            }
            else
            {
                MessageBox.Show("Date Of Receipt Must Be Greater Than Letter Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpin_dtrec.ResetText();
            }
                 
           
        }

        private void dtpin_ldate_CloseUp(object sender, EventArgs e)
        {
            DateTime indate = Convert.ToDateTime(dtpin_date.Text);
            DateTime ldate = Convert.ToDateTime(dtpin_ldate.Text);
            if (ldate <= indate)
            {

            }
            else
            {
                MessageBox.Show("Letter Date Must Be Smaller Than Inward Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpin_ldate.ResetText();
            }
        }

        private void lbl_f_id_Click(object sender, EventArgs e)
        {

        }

        private void lblin_aother_Click(object sender, EventArgs e)
        {

        }

        private void txtin_m_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 120);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 104);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 87);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 30);
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 439, 53);
        }

        private void inwardModeWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeWise m = new ModeWise();
            m.Show();
            
        }

        private void cmbin_atofaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpin_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LBLINREG_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sub_id_Click(object sender, EventArgs e)
        {

        }

        private void txtin_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void inwardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            outward o = new outward();
            o.Show();
            Visible = false;
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_in_no_Click(object sender, EventArgs e)
        {

        }

        private void lbl_in_no_TextChanged(object sender, EventArgs e)
        {
            if (lbl_in_no.Text == "")
            {
                btn_d.Enabled = false;
                btn_u.Enabled = false;

            }
            else
            {
                btn_d.Enabled = true;
                btn_u.Enabled = true;
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.ShowDialog();
        }
    }
}
