using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Profile
{
    public partial class User : Form
    {
        
        public User(String username)
        {
            InitializeComponent();
            this.lbl_Username.Text = username;          
        }

        public void CreateDirectory()
        {
            string windr = Path.GetDirectoryName(Application.ExecutablePath);
            string path = windr + @"\database" + @"\" + lbl_Username.Text;
            string profilepath = windr + @"\database" + @"\" + lbl_Username.Text + @"\profile";
            try
            {
                if (Directory.Exists(profilepath))
                {
                    Console.WriteLine("That path exists already.");
                    //lbl_RStatus.Text = "*This username already exists";
                    return;
                }
                else
                {
                    //lbl_RStatus.Text = "*Succesfully registered";
                }

                DirectoryInfo di = Directory.CreateDirectory(profilepath);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
        private void User_Load(object sender, EventArgs e)
        {
            CreateDirectory();

            string windr = Path.GetDirectoryName(Application.ExecutablePath);

            string datapath = windr + @"\database" + @"\" + lbl_Username.Text + @"\data.txt";
            StreamReader srd = new StreamReader(datapath);
            string name = srd.ReadToEnd().Split('\n')[1];
            lbl_FullName.Text = name;
            srd.Close();
            try
            {
                string profilepath = windr + @"\database" + @"\" + lbl_Username.Text + @"\profile";

                string biopath = profilepath + @"\bio.txt";


                StreamReader sr = new StreamReader(biopath);

                tb_Bio.Text = sr.ReadToEnd();
                //string birthday = sr.ReadToEnd().Split('\n')[1];
                //lbl_Birthday.Text = birthday;
                
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Add biography and complate the profile.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnl_Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            else if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
                {
                    this.Size = new Size(700, 440);
                    this.CenterToScreen();
                }
                else
                {
                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.Location = new Point(0, 0);
                }
            }
        }

        private void pb_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string data = String.Format("Full Name: {0}\nUsername: {1}\nBiography: {2}", lbl_FullName.Text, lbl_Username.Text, tb_Bio.Text);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "data(*.txt)|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(data);
                sw.Close();
            }
        }

        private void btn_ChangePP_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog pp = new OpenFileDialog();
                pp.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png";
                if (pp.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = pp.FileName;
                    pb_Profile.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            string windr = Path.GetDirectoryName(Application.ExecutablePath);

            string profilepath = windr + @"\database" + @"\" + lbl_Username.Text + @"\profile";

            string path = profilepath + @"\bio.txt";

            StreamWriter sw = new StreamWriter(path);

            sw.Write(tb_Bio.Text);
            sw.Close();
            MessageBox.Show("Biography updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
