using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Admin" && txt_password.Text == "Skills@123")
            {
                //Load Registration form
                StudentRegistration reg = new StudentRegistration();
                reg.Show();
                this.Hide();
            }
            else
            {
                //Show Error message
                MessageBox.Show("Invalid Login Credential Please Check User Name And Password", "Invalid Login Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Clear both user name and password text boxes
                txt_username.Clear();
                txt_password.Clear();

                //focus on user name text box
                txt_username.Focus();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //Clear both user name and password text boxes
            txt_username.Clear();
            txt_password.Clear();

            //focus on user name text box
            txt_username.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Close current form
            const string message = "Are you sure, Do you really want to Exit...?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }

        }
        // Add ESC button
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (msg.WParam.ToInt32() == (int)Keys.Escape)
                {
                    const string message = "Are you sure, Do you really want to Exit...?";
                    const string caption = "EXIT";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        //this.Close();
                        Application.Exit();
                    }
                }

                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            catch
            {
                MessageBox.Show("key press any key error");
            }
            return false;
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)

            //Show Hide password
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else

                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
