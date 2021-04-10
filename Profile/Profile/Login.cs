using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Profile
{
    public partial class Login : Form
    {
        public string ReturnUsername { get; set; }
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = null;
        }
        string windr = Path.GetDirectoryName(Application.ExecutablePath);
        public void CreateDirectory(string folderName)
        { 
            string path = windr + @"\database" + @"\" + folderName;
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    lbl_RStatus.Text = "*This username already exists";
                    return;
                }
                else
                {
                    lbl_RStatus.Text = "*Succesfully registered";
                }
                
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string folderName = rtb_Username.Text;
            string path = windr + @"\database" + @"\" + folderName + @"\data.txt";
            
            if (rtb_FullName.Text != "" && rtb_Username.Text != "" && rtb_Password.Text != "" && rtb_PasswordConfirm.Text != "")
            { 
                if(rtb_Password.Text == rtb_PasswordConfirm.Text)
                {
                    CreateDirectory(folderName);

                    var myFile = File.Create(path);
                    myFile.Close();
                    StreamWriter sw = new StreamWriter(path);
                    string data = rtb_Username.Text + Environment.NewLine + rtb_FullName.Text + Environment.NewLine + rtb_Password.Text;
                    sw.Write(data);
                    sw.Close();

                    //string folderpath = windr + @"\database" + @"\" + folderName;
                    
                }
                else
                {
                    lbl_RStatus.Text = "*Passwords do not match";
                }
            }
            else
            {
                lbl_RStatus.Text = "*Please fill all area";
            }
            if (lbl_RStatus.Text == "*Succesfully registered")
            {
                pnl_Register.Visible = false;
                pnl_Login.Visible = true;
                lbl_ConfirmStatus.Text = "*Succesfully registered";
            }
            else if (lbl_RStatus.Text == "*This username already exists")
            {
                pnl_Register.Visible = true;
                pnl_Login.Visible = false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            lbl_ConfirmStatus.Text = "";
            string path = windr + @"\database" + @"\" + tb_Username.Text + @"\data.txt";
            string loginpath = windr + @"\database" + @"\" + tb_Username.Text;
            if (Directory.Exists(loginpath) && tb_Password.Text != "" && tb_Username.Text != "")
            {
                Console.WriteLine("That path exists.");
                string password = File.ReadLines(path).Last();
                if (tb_Password.Text == password)
                {
                    User user = new User(tb_Username.Text);
                    user.Show();
                    this.Hide();
                }
                else
                {
                    lbl_Status.Text = "*Invalid password";
                }
            }
            else
            {
                lbl_Status.Text = "*Username doesn't exist";
            }       
        }

        private void ll_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Register.Visible = false;
            pnl_Login.Visible = true;

            tb_Username.Text = "";
            tb_Password.Text = "";
        }

        private void ll_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Register.Visible = true;
            pnl_Login.Visible = false;
            this.ActiveControl = null;

            rtb_FullName.Text = "";
            rtb_Username.Text = "";
            rtb_Password.Text = "";
            rtb_PasswordConfirm.Text = "";
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
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtb_PasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_RShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_RShowPass.Checked)
            {
                rtb_Password.PasswordChar = '\0';
                rtb_PasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                rtb_Password.PasswordChar = '•';
                rtb_PasswordConfirm.PasswordChar = '•';
            }
            
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                tb_Password.PasswordChar = '\0';
            }
            else
            {
                tb_Password.PasswordChar = '•';
            }
        }

        private void btn_RClear_Click(object sender, EventArgs e)
        {
            rtb_FullName.Text = "";
            rtb_Username.Text = "";
            rtb_Password.Text = "";
            rtb_PasswordConfirm.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            tb_Password.Text = "";
        }

        private void pnl_Register_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
