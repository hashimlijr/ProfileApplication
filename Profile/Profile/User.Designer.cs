
namespace Profile
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pnl_Move = new System.Windows.Forms.Panel();
            this.pb_Maximize = new System.Windows.Forms.PictureBox();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.pnl_profile = new System.Windows.Forms.Panel();
            this.pnl_About = new System.Windows.Forms.Panel();
            this.lbl_About = new System.Windows.Forms.Label();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.lbl_Bio = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_ChangePP = new System.Windows.Forms.Button();
            this.pb_Profile = new System.Windows.Forms.PictureBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.pnl_Bio = new System.Windows.Forms.Panel();
            this.tb_Bio = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pnl_LeftSpace = new System.Windows.Forms.Panel();
            this.pnl_Move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnl_profile.SuspendLayout();
            this.pnl_About.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).BeginInit();
            this.pnl_Bio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Move
            // 
            this.pnl_Move.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Move.Controls.Add(this.pb_Maximize);
            this.pnl_Move.Controls.Add(this.pb_Minimize);
            this.pnl_Move.Controls.Add(this.pb_Close);
            this.pnl_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Move.Location = new System.Drawing.Point(0, 0);
            this.pnl_Move.Name = "pnl_Move";
            this.pnl_Move.Size = new System.Drawing.Size(1009, 27);
            this.pnl_Move.TabIndex = 0;
            this.pnl_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Move_MouseDown);
            // 
            // pb_Maximize
            // 
            this.pb_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Maximize.Image = global::Profile.Properties.Resources.circle_16;
            this.pb_Maximize.Location = new System.Drawing.Point(919, 0);
            this.pb_Maximize.Name = "pb_Maximize";
            this.pb_Maximize.Size = new System.Drawing.Size(30, 27);
            this.pb_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Maximize.TabIndex = 10;
            this.pb_Maximize.TabStop = false;
            this.pb_Maximize.Click += new System.EventHandler(this.pb_Maximize_Click);
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Minimize.Image = global::Profile.Properties.Resources.circle_16_2_;
            this.pb_Minimize.Location = new System.Drawing.Point(949, 0);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(30, 27);
            this.pb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Minimize.TabIndex = 9;
            this.pb_Minimize.TabStop = false;
            this.pb_Minimize.Click += new System.EventHandler(this.pb_Minimize_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_Close.Image = global::Profile.Properties.Resources.circle_16_1_;
            this.pb_Close.Location = new System.Drawing.Point(979, 0);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(30, 27);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Close.TabIndex = 8;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Username.Location = new System.Drawing.Point(53, 37);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(143, 35);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.BlueViolet;
            this.pnl_Menu.Controls.Add(this.btn_Save);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.btn_Profile);
            this.pnl_Menu.Controls.Add(this.lbl_Username);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 27);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(249, 602);
            this.pnl_Menu.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Image = global::Profile.Properties.Resources.diskette;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.Location = new System.Drawing.Point(0, 244);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(249, 115);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = " Download";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Logout.Image = global::Profile.Properties.Resources.logout;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.Location = new System.Drawing.Point(0, 487);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(249, 115);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = " Logout";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Profile.Image = global::Profile.Properties.Resources.user;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Profile.Location = new System.Drawing.Point(0, 108);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(249, 115);
            this.btn_Profile.TabIndex = 4;
            this.btn_Profile.Text = " Profile";
            this.btn_Profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Profile.UseVisualStyleBackColor = true;
            // 
            // pnl_profile
            // 
            this.pnl_profile.Controls.Add(this.pnl_About);
            this.pnl_profile.Controls.Add(this.pnl_Bottom);
            this.pnl_profile.Controls.Add(this.pnl_Top);
            this.pnl_profile.Controls.Add(this.pnl_Bio);
            this.pnl_profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_profile.Location = new System.Drawing.Point(249, 27);
            this.pnl_profile.Name = "pnl_profile";
            this.pnl_profile.Size = new System.Drawing.Size(760, 602);
            this.pnl_profile.TabIndex = 5;
            // 
            // pnl_About
            // 
            this.pnl_About.Controls.Add(this.lbl_About);
            this.pnl_About.Controls.Add(this.lbl_Line);
            this.pnl_About.Controls.Add(this.lbl_Bio);
            this.pnl_About.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_About.Location = new System.Drawing.Point(0, 252);
            this.pnl_About.Name = "pnl_About";
            this.pnl_About.Size = new System.Drawing.Size(760, 114);
            this.pnl_About.TabIndex = 18;
            // 
            // lbl_About
            // 
            this.lbl_About.AutoSize = true;
            this.lbl_About.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_About.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_About.Location = new System.Drawing.Point(117, 30);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(103, 33);
            this.lbl_About.TabIndex = 11;
            this.lbl_About.Text = "About";
            // 
            // lbl_Line
            // 
            this.lbl_Line.AutoSize = true;
            this.lbl_Line.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Line.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Line.Location = new System.Drawing.Point(117, 48);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(550, 23);
            this.lbl_Line.TabIndex = 12;
            this.lbl_Line.Text = "_____________________________________________";
            // 
            // lbl_Bio
            // 
            this.lbl_Bio.AutoSize = true;
            this.lbl_Bio.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bio.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_Bio.Location = new System.Drawing.Point(119, 87);
            this.lbl_Bio.Name = "lbl_Bio";
            this.lbl_Bio.Size = new System.Drawing.Size(129, 20);
            this.lbl_Bio.TabIndex = 10;
            this.lbl_Bio.Text = "Biography ↓";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 570);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(760, 32);
            this.pnl_Bottom.TabIndex = 17;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.btn_ChangePP);
            this.pnl_Top.Controls.Add(this.pb_Profile);
            this.pnl_Top.Controls.Add(this.lbl_FullName);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(760, 252);
            this.pnl_Top.TabIndex = 15;
            // 
            // btn_ChangePP
            // 
            this.btn_ChangePP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ChangePP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePP.FlatAppearance.BorderSize = 0;
            this.btn_ChangePP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePP.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChangePP.Location = new System.Drawing.Point(386, 204);
            this.btn_ChangePP.Name = "btn_ChangePP";
            this.btn_ChangePP.Size = new System.Drawing.Size(125, 40);
            this.btn_ChangePP.TabIndex = 7;
            this.btn_ChangePP.Text = "Upload";
            this.btn_ChangePP.UseVisualStyleBackColor = false;
            this.btn_ChangePP.Click += new System.EventHandler(this.btn_ChangePP_Click);
            // 
            // pb_Profile
            // 
            this.pb_Profile.ErrorImage = global::Profile.Properties.Resources.profile_user;
            this.pb_Profile.Image = global::Profile.Properties.Resources.profile_user;
            this.pb_Profile.Location = new System.Drawing.Point(120, 6);
            this.pb_Profile.Name = "pb_Profile";
            this.pb_Profile.Size = new System.Drawing.Size(249, 238);
            this.pb_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Profile.TabIndex = 1;
            this.pb_Profile.TabStop = false;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_FullName.Location = new System.Drawing.Point(378, 108);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(187, 44);
            this.lbl_FullName.TabIndex = 0;
            this.lbl_FullName.Text = "Full Name";
            // 
            // pnl_Bio
            // 
            this.pnl_Bio.Controls.Add(this.tb_Bio);
            this.pnl_Bio.Controls.Add(this.btn_Update);
            this.pnl_Bio.Location = new System.Drawing.Point(123, 372);
            this.pnl_Bio.Name = "pnl_Bio";
            this.pnl_Bio.Size = new System.Drawing.Size(634, 201);
            this.pnl_Bio.TabIndex = 13;
            // 
            // tb_Bio
            // 
            this.tb_Bio.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Bio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Bio.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Bio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bio.Location = new System.Drawing.Point(0, 0);
            this.tb_Bio.Multiline = true;
            this.tb_Bio.Name = "tb_Bio";
            this.tb_Bio.Size = new System.Drawing.Size(634, 93);
            this.tb_Bio.TabIndex = 5;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(482, 158);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(125, 40);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // pnl_LeftSpace
            // 
            this.pnl_LeftSpace.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_LeftSpace.Location = new System.Drawing.Point(249, 27);
            this.pnl_LeftSpace.Name = "pnl_LeftSpace";
            this.pnl_LeftSpace.Size = new System.Drawing.Size(117, 602);
            this.pnl_LeftSpace.TabIndex = 14;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 629);
            this.Controls.Add(this.pnl_LeftSpace);
            this.Controls.Add(this.pnl_profile);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.pnl_Move.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_profile.ResumeLayout(false);
            this.pnl_About.ResumeLayout(false);
            this.pnl_About.PerformLayout();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).EndInit();
            this.pnl_Bio.ResumeLayout(false);
            this.pnl_Bio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Move;
        private System.Windows.Forms.PictureBox pb_Maximize;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_profile;
        private System.Windows.Forms.Panel pnl_About;
        private System.Windows.Forms.Label lbl_Bio;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_Bio;
        private System.Windows.Forms.TextBox tb_Bio;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel pnl_LeftSpace;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pb_Profile;
        private System.Windows.Forms.Button btn_ChangePP;
        private System.Windows.Forms.Label lbl_About;
        private System.Windows.Forms.Label lbl_Line;
    }
}