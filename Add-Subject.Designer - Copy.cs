namespace Inword_Outword
{
    partial class Add_Subject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Subject));
            this.dgvsubject = new System.Windows.Forms.DataGridView();
            this.subidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akimssDataSet = new Inword_Outword.akimssDataSet();
            this.btn_s = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.LBLADDSUB = new System.Windows.Forms.Label();
            this.btn_c = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.txts_desc = new System.Windows.Forms.TextBox();
            this.lbls_desc = new System.Windows.Forms.Label();
            this.lbl_s_id = new System.Windows.Forms.Label();
            this.lbls_id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLOUTREG = new System.Windows.Forms.Label();
            this.subjectTableAdapter = new Inword_Outword.akimssDataSetTableAdapters.subjectTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inwardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.outwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akimssDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsubject
            // 
            this.dgvsubject.AutoGenerateColumns = false;
            this.dgvsubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvsubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subidDataGridViewTextBoxColumn,
            this.subdescDataGridViewTextBoxColumn});
            this.dgvsubject.DataSource = this.subjectBindingSource;
            this.dgvsubject.Location = new System.Drawing.Point(813, 255);
            this.dgvsubject.Name = "dgvsubject";
            this.dgvsubject.RowTemplate.Height = 24;
            this.dgvsubject.Size = new System.Drawing.Size(403, 444);
            this.dgvsubject.TabIndex = 13;
            this.dgvsubject.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsubject_RowHeaderMouseClick);
            // 
            // subidDataGridViewTextBoxColumn
            // 
            this.subidDataGridViewTextBoxColumn.DataPropertyName = "sub_id";
            this.subidDataGridViewTextBoxColumn.HeaderText = "Subject ID";
            this.subidDataGridViewTextBoxColumn.Name = "subidDataGridViewTextBoxColumn";
            this.subidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subdescDataGridViewTextBoxColumn
            // 
            this.subdescDataGridViewTextBoxColumn.DataPropertyName = "sub_desc";
            this.subdescDataGridViewTextBoxColumn.HeaderText = "Subject Description";
            this.subdescDataGridViewTextBoxColumn.Name = "subdescDataGridViewTextBoxColumn";
            this.subdescDataGridViewTextBoxColumn.Width = 150;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.akimssDataSet;
            // 
            // akimssDataSet
            // 
            this.akimssDataSet.DataSetName = "akimssDataSet";
            this.akimssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_s
            // 
            this.btn_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s.Location = new System.Drawing.Point(195, 668);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(82, 31);
            this.btn_s.TabIndex = 9;
            this.btn_s.Text = "SAVE";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // btn_u
            // 
            this.btn_u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_u.Location = new System.Drawing.Point(344, 668);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(108, 31);
            this.btn_u.TabIndex = 10;
            this.btn_u.Text = "MODIFY";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // btn_d
            // 
            this.btn_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d.Location = new System.Drawing.Point(508, 668);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(101, 31);
            this.btn_d.TabIndex = 11;
            this.btn_d.Text = "DELETE";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // LBLADDSUB
            // 
            this.LBLADDSUB.AutoSize = true;
            this.LBLADDSUB.BackColor = System.Drawing.Color.DarkOrange;
            this.LBLADDSUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLADDSUB.ForeColor = System.Drawing.Color.White;
            this.LBLADDSUB.Location = new System.Drawing.Point(671, 125);
            this.LBLADDSUB.Name = "LBLADDSUB";
            this.LBLADDSUB.Size = new System.Drawing.Size(139, 20);
            this.LBLADDSUB.TabIndex = 44;
            this.LBLADDSUB.Text = "ADD SUBJECT";
            // 
            // btn_c
            // 
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(34, 668);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(99, 31);
            this.btn_c.TabIndex = 2;
            this.btn_c.Text = "NEW";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // button_exit
            // 
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(1124, 198);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(92, 31);
            this.button_exit.TabIndex = 12;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // txts_desc
            // 
            this.txts_desc.Location = new System.Drawing.Point(291, 94);
            this.txts_desc.Name = "txts_desc";
            this.txts_desc.Size = new System.Drawing.Size(215, 22);
            this.txts_desc.TabIndex = 1;
            // 
            // lbls_desc
            // 
            this.lbls_desc.AutoSize = true;
            this.lbls_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_desc.Location = new System.Drawing.Point(35, 96);
            this.lbls_desc.Name = "lbls_desc";
            this.lbls_desc.Size = new System.Drawing.Size(130, 17);
            this.lbls_desc.TabIndex = 2;
            this.lbls_desc.Text = "Subject Description";
            // 
            // lbl_s_id
            // 
            this.lbl_s_id.AutoSize = true;
            this.lbl_s_id.Location = new System.Drawing.Point(288, 28);
            this.lbl_s_id.Name = "lbl_s_id";
            this.lbl_s_id.Size = new System.Drawing.Size(52, 17);
            this.lbl_s_id.TabIndex = 1;
            this.lbl_s_id.Text = "Sub_Id";
            // 
            // lbls_id
            // 
            this.lbls_id.AutoSize = true;
            this.lbls_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls_id.Location = new System.Drawing.Point(35, 27);
            this.lbls_id.Name = "lbls_id";
            this.lbls_id.Size = new System.Drawing.Size(72, 17);
            this.lbls_id.TabIndex = 0;
            this.lbls_id.Text = "Subject ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_s_id);
            this.panel2.Controls.Add(this.txts_desc);
            this.panel2.Controls.Add(this.lbls_desc);
            this.panel2.Controls.Add(this.lbls_id);
            this.panel2.Location = new System.Drawing.Point(34, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 153);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inword_Outword.Properties.Resources.BV;
            this.pictureBox1.Location = new System.Drawing.Point(7, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // LBLOUTREG
            // 
            this.LBLOUTREG.AutoSize = true;
            this.LBLOUTREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLOUTREG.ForeColor = System.Drawing.Color.Black;
            this.LBLOUTREG.Location = new System.Drawing.Point(401, 34);
            this.LBLOUTREG.Name = "LBLOUTREG";
            this.LBLOUTREG.Size = new System.Drawing.Size(679, 75);
            this.LBLOUTREG.TabIndex = 63;
            this.LBLOUTREG.Text = "Bharati Vidyapeeth\r\n(Deemed To Be) University, Pune\r\nAbhijit Kadam Institute of M" +
    "anagement and Social Sciences, Solapur.\r\n";
            this.LBLOUTREG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inwardToolStripMenuItem2,
            this.outwardToolStripMenuItem1,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1379, 31);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inwardToolStripMenuItem2
            // 
            this.inwardToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwardToolStripMenuItem2.Name = "inwardToolStripMenuItem2";
            this.inwardToolStripMenuItem2.Size = new System.Drawing.Size(88, 27);
            this.inwardToolStripMenuItem2.Text = "INWARD";
            this.inwardToolStripMenuItem2.Click += new System.EventHandler(this.inwardToolStripMenuItem2_Click);
            // 
            // outwardToolStripMenuItem1
            // 
            this.outwardToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outwardToolStripMenuItem1.Name = "outwardToolStripMenuItem1";
            this.outwardToolStripMenuItem1.Size = new System.Drawing.Size(104, 27);
            this.outwardToolStripMenuItem1.Text = "OUTWARD";
            this.outwardToolStripMenuItem1.Click += new System.EventHandler(this.outwardToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.aboutUsToolStripMenuItem.Text = "ABOUT US";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // Add_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBLOUTREG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.LBLADDSUB);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_u);
            this.Controls.Add(this.btn_s);
            this.Controls.Add(this.dgvsubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subject";
            this.Load += new System.EventHandler(this.Add_Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akimssDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsubject;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Label LBLADDSUB;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox txts_desc;
        private System.Windows.Forms.Label lbls_desc;
        private System.Windows.Forms.Label lbl_s_id;
        private System.Windows.Forms.Label lbls_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLOUTREG;
        private akimssDataSet akimssDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private akimssDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdescDataGridViewTextBoxColumn;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inwardToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem outwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}