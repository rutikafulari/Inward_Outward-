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
    public partial class Main_Menu : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void LBLMAINMENU_Click(object sender, EventArgs e)
        {

        }

        private void button_inward_Click(object sender, EventArgs e)
        {
            //Inward i = new Inward();
            //i.Show();
            //Visible = false;
        }

        private void button_outward_Click(object sender, EventArgs e)
        {
            //outward o = new outward();
            //o.Show();
            //Visible = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0, 0);



            //lbldate.Text = DateTime.Now.ToLongDateString();
            //lbltime.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();


            foreach (Control ctl in  this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;
                    Mdi.BackColor = System.Drawing.Color.White;
                }
                catch (Exception a)
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbltime.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            
                inreport i = new inreport();
                i.ShowDialog();
               
                
                
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void inwardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inward i = new Inward();
            
            i.Show();
            
        }

        private void outwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outward o = new outward();
            o.Show();
            
        }

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "_" + d.Month;
            string servername = "LAPTOP-GR01H1AK";
            string dbname = "akimss";
            string aaa = @"Data Source =" + servername + ";integrated security=true;Initial catalog=" + dbname + "";
            SqlConnection cn = new SqlConnection(aaa);


            cn.Open();
            string str = "USE " + dbname + ";";
            string str1 = "BACKUP DATABASE " + dbname + " TO DISK = 'E:\\Backup\\" + dbname + "_" + dd + ".Bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups' , NAME = 'Full Backup of " + dbname +"';";
            SqlCommand cmd1 = new SqlCommand(str, cn);
            SqlCommand cmd2 = new SqlCommand(str1, cn);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully Completed Backup. You can find this file (akimss.Bak) in your Disk E:\\Backup\\... Never edit this file name.");
            cn.Close();
        }

        private void modeWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeWise m = new ModeWise();
            m.ShowDialog();
        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateWise d = new DateWise();
            d.ShowDialog();
        }

        private void academicYearWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcademicYearWise a = new AcademicYearWise();
            a.ShowDialog();
        }

        private void subjectWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectWise s = new SubjectWise();
            s.ShowDialog();
        }

        private void cityWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityWise c = new CityWise();
            c.ShowDialog();
        }

        private void facultyWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyWise f = new FacultyWise();
            f.ShowDialog();
        }

        private void outwardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Outreport o = new Outreport();
            o.ShowDialog();
        }

        private void subjectWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outsubwise os = new outsubwise();
            os.ShowDialog();
        }

        private void fromWhomReceivedWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WrecWise w = new WrecWise();
            w.ShowDialog();
        }

        private void toWhomWeSentWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outwhomsentwise ow = new outwhomsentwise();
            ow.ShowDialog();
        }

        private void modeWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outmodewise om = new outmodewise();
            om.ShowDialog();
        }

        private void facultyWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outfacultywise of = new outfacultywise();
            of.ShowDialog();
        }

        private void dateWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outdatewise od = new outdatewise();
            od.ShowDialog();
        }

        private void cityWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outcitywise oc = new outcitywise();
            oc.ShowDialog();
        }

        private void addressWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outaddresswise oa = new outaddresswise();
            oa.ShowDialog();
        }

        private void academicYearWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outyrwise oy = new outyrwise();
            oy.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.ShowDialog();
        }
    }
}
