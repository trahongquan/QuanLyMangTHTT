namespace QuanLyMangTHTT
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lb_Home = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btn_QLCTH = new System.Windows.Forms.Button();
            this.btn_QLTB = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Body = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.panelTop.Controls.Add(this.lb_Home);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(138, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(502, 41);
            this.panelTop.TabIndex = 1;
            // 
            // lb_Home
            // 
            this.lb_Home.AutoSize = true;
            this.lb_Home.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Home.ForeColor = System.Drawing.Color.White;
            this.lb_Home.Location = new System.Drawing.Point(6, 7);
            this.lb_Home.Name = "lb_Home";
            this.lb_Home.Size = new System.Drawing.Size(82, 19);
            this.lb_Home.TabIndex = 0;
            this.lb_Home.Text = "Trang chủ";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.panelLeft.Controls.Add(this.btn_QLCTH);
            this.panelLeft.Controls.Add(this.btn_QLTB);
            this.panelLeft.Controls.Add(this.btn_QLNV);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(138, 360);
            this.panelLeft.TabIndex = 0;
            // 
            // btn_QLCTH
            // 
            this.btn_QLCTH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_QLCTH.FlatAppearance.BorderSize = 0;
            this.btn_QLCTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLCTH.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLCTH.ForeColor = System.Drawing.Color.White;
            this.btn_QLCTH.Image = global::QuanLyMangTHTT.Properties.Resources.cluster_computing;
            this.btn_QLCTH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLCTH.Location = new System.Drawing.Point(-2, 240);
            this.btn_QLCTH.Name = "btn_QLCTH";
            this.btn_QLCTH.Size = new System.Drawing.Size(130, 30);
            this.btn_QLCTH.TabIndex = 1;
            this.btn_QLCTH.Text = "      Mạng THTT";
            this.btn_QLCTH.UseVisualStyleBackColor = false;
            this.btn_QLCTH.Click += new System.EventHandler(this.btn_QLCTH_Click);
            // 
            // btn_QLTB
            // 
            this.btn_QLTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_QLTB.FlatAppearance.BorderSize = 0;
            this.btn_QLTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLTB.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLTB.ForeColor = System.Drawing.Color.White;
            this.btn_QLTB.Image = global::QuanLyMangTHTT.Properties.Resources.electrical;
            this.btn_QLTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLTB.Location = new System.Drawing.Point(-2, 176);
            this.btn_QLTB.Name = "btn_QLTB";
            this.btn_QLTB.Size = new System.Drawing.Size(130, 30);
            this.btn_QLTB.TabIndex = 1;
            this.btn_QLTB.Text = "   QL Thiết bị";
            this.btn_QLTB.UseVisualStyleBackColor = false;
            this.btn_QLTB.Click += new System.EventHandler(this.btn_QLTB_Click);
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_QLNV.FlatAppearance.BorderSize = 0;
            this.btn_QLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNV.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNV.ForeColor = System.Drawing.Color.White;
            this.btn_QLNV.Image = global::QuanLyMangTHTT.Properties.Resources.group;
            this.btn_QLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNV.Location = new System.Drawing.Point(-2, 112);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(130, 30);
            this.btn_QLNV.TabIndex = 1;
            this.btn_QLNV.Text = "       QL Nhân viên";
            this.btn_QLNV.UseVisualStyleBackColor = false;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QuanLyMangTHTT.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pn_Body
            // 
            this.pn_Body.BackColor = System.Drawing.Color.White;
            this.pn_Body.BackgroundImage = global::QuanLyMangTHTT.Properties.Resources.Background_lich_su_Viet_Nam;
            this.pn_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Body.Location = new System.Drawing.Point(138, 41);
            this.pn_Body.Name = "pn_Body";
            this.pn_Body.Size = new System.Drawing.Size(502, 319);
            this.pn_Body.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.pn_Body);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lb_Home;
        private System.Windows.Forms.Button btn_QLNV;
        private System.Windows.Forms.Button btn_QLTB;
        private System.Windows.Forms.Button btn_QLCTH;
        private System.Windows.Forms.Panel pn_Body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeft;
    }
}

