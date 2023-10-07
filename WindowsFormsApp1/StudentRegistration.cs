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

namespace WindowsFormsApp1
{
    public partial class StudentRegistration : Form
    {
        //Creating Sql connection toconnect database
        SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=SkillsInternational;Integrated Security=True");

        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void lbl_FirstName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ParentName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_HomePhone_Click(object sender, EventArgs e)
        {

        }

        private void lnk_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string message = "Are you sure, Do you really want to Logout...?";
            const string caption = "Logout";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
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
                    const string caption = "Exit";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                        //this.Hide();
                        //Login login = new Login();
                        //login.Show();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        this.Close();

                        //this.Hide();
                        //Login login = new Login();
                        //login.Show();
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

        private void lnk_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string message = "Are you sure, Do you really want to Exit...?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                //this.Hide();
                //Login login = new Login();
                //login.Show();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
                //this.Hide();
                //Login login = new Login();
                //login.Show();
            }

            //this.Hide();
            //Login login = new Login();
            //login.Show();

        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            //Populate reg No data
            PopulateRegNumber();
            //Get value from regNo
            int regNo = Convert.ToInt32(com_RegNo.SelectedValue.ToString());
            //Populate data controls
            PopulateControls(regNo);
        }

        //Write acode for populate dropdown
        private void PopulateRegNumber()
        {
            try
            {
                //Open Database Connection
                con.Open();
                //Creat Datatable Object
                DataTable dt = new DataTable();
                //Extrate Data Form Sql Data Adaptor
                SqlDataAdapter adapter = new SqlDataAdapter("select regNo From  Student",con);
                //Fill  The Adaptor With Data
                adapter.Fill(dt);
                con.Close();

                //Bind Data Dropdown control
                com_RegNo.DataSource = dt;
                com_RegNo.DisplayMember = "regNo";
                com_RegNo.ValueMember = "regNo";

            }
            catch(Exception ex)
            {
            }
            finally 
            {
                //Close The Connection
                con.Close();
            }
        }

        private void PopulateControls(int regNo) 
        {
            //Creat Datatable Object
            DataTable dt = new DataTable();
            try 
            {
                //Open Database Connection
                con.Open();
                //Create Sql command
                SqlCommand cmd = new SqlCommand("select * From  Student where regNo=@regNo", con);
                //Add parameters
                cmd.Parameters.AddWithValue("@regNo",regNo);
                //Extrate Data Form Sql Data Adaptor
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Fill  The Adaptor With Data
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to popualte controls");
                //MessageBox.Show("error" + ex);
            }
            finally 
            {
                con.Close();
            }
            //populate all controls
            txt_FirstName.Text = dt.Rows[0]["firstName"].ToString();
            txt_LastName.Text = dt.Rows[0]["lastName"].ToString();
            txt_Email.Text = dt.Rows[0]["email"].ToString();
            txt_Address.Text = dt.Rows[0]["address"].ToString();
            txt_MobilePhone.Text = dt.Rows[0]["mobilePhone"].ToString();
            txt_HomePhone.Text = dt.Rows[0]["homePhone"].ToString();
            txt_ParentName.Text = dt.Rows[0]["parentName"].ToString();
            txt_ContactNumber.Text = dt.Rows[0]["contactNo"].ToString();
            txt_NIC.Text = dt.Rows[0]["nic"].ToString();
            pkr_DateofBirth.Text = dt.Rows[0]["dateOfBirth"].ToString();
            string gender = dt.Rows[0]["gender"].ToString();
            if(gender == "Male") 
            {
                opt_Male.Checked = true;
                opt_Female.Checked = false;   
            }
            else 
            {
                opt_Male.Checked = false;
                opt_Female.Checked = true;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            //Disble RegNo combobox
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            com_RegNo.Enabled = false;
            if (btn_Register.Text == "Register")
            {
                Enblecontrols();

                //Emty All Text boxes and default values for other controls
                txt_FirstName.Text = "";
                txt_LastName.Text = "";
                txt_Email.Text = "";
                txt_Address.Text = "";
                txt_MobilePhone.Text = "";
                txt_HomePhone.Text = "";
                txt_ParentName.Text = "";
                txt_ContactNumber.Text = "";
                txt_NIC.Text = "";
                pkr_DateofBirth.Text = DateTime.Now.ToString();
                opt_Male.Checked = false;
                opt_Female.Checked = false;
                btn_Register.Text = "Save";
            }
            else if (btn_Register.Text == "Save")
            {

                if (txt_FirstName.Text == "" && txt_LastName.Text == "")
                {
                    MessageBox.Show("Please complete the form");

                }
                else
                {
                    //save code
                    //Creat Sql command object to insert data to table
                    string commandString = @"INSERT INTO [dbo].[Student]
                                        ([firstName],[lastName],[dateOfBirth],
                                        [gender],[address],[email],[mobilePhone],
                                        [homePhone],[parentName],[nic],
                                        [contactNo])
                                        VALUES
                                        (@firstName, @lastName,@dateOfBirth,
                                        @gender,@address,@email,
                                        @mobilePhone,@homePhone,@parentName,
                                        @nic,@contactNo)";

                    //Create Sql commend object to insert data to table
                    SqlCommand cmd = new SqlCommand(commandString, con);

                    //Open database connection
                    con.Open();

                    //Set Sql parameters with values
                    cmd.Parameters.AddWithValue("@firstName", txt_FirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txt_LastName.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth", Convert.ToDateTime(pkr_DateofBirth.Text));
                    cmd.Parameters.AddWithValue("@gender", GetGender());
                    cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@mobilePhone", txt_MobilePhone.Text);
                    cmd.Parameters.AddWithValue("@homePhone", txt_HomePhone.Text);
                    cmd.Parameters.AddWithValue("@parentName", txt_ParentName.Text);
                    cmd.Parameters.AddWithValue("@nic", txt_NIC.Text);
                    cmd.Parameters.AddWithValue("@contactNo", txt_ContactNumber.Text);

                    con.Close();
                    try
                    {
                        //open database connection
                        con.Open();
                        DataTable dt = new DataTable();

                        //Execute non query commend
                        cmd.ExecuteNonQuery();

                        //show successful message
                        MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        //Show faliure message
                        MessageBox.Show("Add New Record Failed", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show("error"+ex);
                    }
                    finally
                    {
                        //Close the connection
                        con.Close();
                        //Reloard form back to initial state
                        ReLoadForm();
                    }

                    clearData();

                }

            }
        }

        // Get Gender code
        private string GetGender() 
        {
            if (opt_Male.Checked == true) 
            {
                return "Male";
            }
            else if (opt_Female.Checked == true) 
            {
                return "Female";
            }
            else 
            {
                return "undefine";
            }
        }


        private void Enblecontrols()
            {
            //Disable regNo combobox
            com_RegNo.Enabled = false;

            //Enble all other data input controls
                txt_FirstName.ReadOnly = false;
                txt_LastName.ReadOnly = false;
                txt_Email.ReadOnly = false;
                txt_Address.ReadOnly = false;
                txt_MobilePhone.ReadOnly = false;
                txt_HomePhone.ReadOnly = false;
                txt_ParentName.ReadOnly = false;
                txt_ContactNumber.ReadOnly = false;
                txt_NIC.ReadOnly = false;

                pkr_DateofBirth.Enabled = true;
                opt_Male.Enabled = true;
                opt_Female.Enabled = true;

            btn_Register.Text = "Register";
            btn_Update.Text = "Update";
        }

        private void btn_Update_Click(object sender, EventArgs e)
            {
            btn_Delete.Enabled = false;
            btn_Register.Enabled = false;
            if (btn_Update.Text == "Update") 
            {
                Enblecontrols();
                btn_Update.Text = "Save";
            }
            else if (btn_Update.Text == "Save") 
            {
                //Difine Sql command string
                string commandString = @"UPDATE [dbo].[Student]
                                       SET [firstName] = @firstName,
                                       [lastName] = @lastName,
                                       [dateOfBirth] = @dateOfBirth,
                                       [gender] = @gender,
                                       [address] = @address,
                                       [email] = @email,
                                       [mobilePhone] = @mobilePhone,
                                       [homePhone] = @homePhone,
                                       [parentName] = @parentName,
                                       [NIC] = @NIC,
                                       [contactNo] = @contactNo
                                       WHERE regNo=@regNo";

                //Create Sql commend object to insert data to table
                SqlCommand cmd = new SqlCommand(commandString, con);

                //Set Sql parameters with values
                cmd.Parameters.AddWithValue("@firstName", txt_FirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txt_LastName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", Convert.ToDateTime(pkr_DateofBirth.Text));
                cmd.Parameters.AddWithValue("@gender", GetGender());
                cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", txt_MobilePhone.Text);
                cmd.Parameters.AddWithValue("@homePhone", txt_HomePhone.Text);
                cmd.Parameters.AddWithValue("@parentName", txt_ParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txt_NIC.Text);
                cmd.Parameters.AddWithValue("@contactNo", txt_ContactNumber.Text);
                cmd.Parameters.AddWithValue("@regNo",Convert.ToInt32(com_RegNo.Text));

                try
                {
                    //open database connection
                    con.Open();
                    DataTable dt = new DataTable();

                    //Execute non query commend
                    cmd.ExecuteNonQuery();

                    //show successful message
                    MessageBox.Show("Record Update Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    //Show faliure message
                    MessageBox.Show("Update Record Failed", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("error"+ex);
                }
                finally
                {
                    //Close the connection
                    con.Close();
                    //Reloard form back to initial state
                    ReLoadForm();
                }
                clearData();
            }

            }

        private void opt_Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opt_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_RegNo_Click(object sender, EventArgs e)
        {

        }

        private void com_RegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //convert selected value string and assing
            string SelectedValue = com_RegNo.SelectedValue.ToString();
            //declare regNo
            int regNo;

            //check selected value is integer and if true repopulate countrols
            if (int.TryParse(SelectedValue, out regNo)) 
            {
                //Get value from regNo
                regNo = Convert.ToInt32(SelectedValue);
                //populate data controls
                PopulateControls(regNo);
            }
            else 
            {
            }

        }

        //Turn form back to initial state
        private void ReLoadForm() 
        {
            //Disable regNo combobox
            com_RegNo.Enabled = true;

            //Enble all other data input controls
            txt_FirstName.ReadOnly = true;
            txt_LastName.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_Address.ReadOnly = true;
            txt_MobilePhone.ReadOnly = true;
            txt_HomePhone.ReadOnly = true;
            txt_ParentName.ReadOnly = true;
            txt_ContactNumber.ReadOnly = true;
            txt_NIC.ReadOnly = true;

            pkr_DateofBirth.Enabled = false;
            opt_Male.Enabled = false;
            opt_Female.Enabled = false;

            //Populate reg No data
            PopulateRegNumber();
            //Get value from regNo
            int regNo = Convert.ToInt32(com_RegNo.SelectedValue.ToString());
            //Populate data controls
            PopulateControls(regNo);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearData();    
        
        }

        private void clearData()
        {
            //  throw new NotImplementedException();
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Email.Text = "";
            txt_Address.Text = "";
            txt_MobilePhone.Text = "";
            txt_HomePhone.Text = "";
            txt_ParentName.Text = "";
            txt_ContactNumber.Text = "";
            txt_NIC.Text = "";
            opt_Male.Checked = false;
            opt_Female.Checked = false;
            pkr_DateofBirth.Text = DateTime.Now.ToString();

            com_RegNo.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;
            btn_Register.Enabled = true;

            txt_FirstName.ReadOnly = true;
            txt_LastName.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_Address.ReadOnly = true;
            txt_MobilePhone.ReadOnly = true;
            txt_HomePhone.ReadOnly = true;
            txt_ParentName.ReadOnly = true;
            txt_ContactNumber.ReadOnly = true;
            txt_NIC.ReadOnly = true;

            pkr_DateofBirth.Enabled = false;
            opt_Male.Enabled = false;
            opt_Female.Enabled = false;

            btn_Register.Text = "Register";

            btn_Update.Text = "Update";

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, Do you really want to delete this record...?", "Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string commandString = @"DELETE FROM [dbo].[Student]
                                         WHERE regNo=@regNo";
                SqlCommand cmd = new SqlCommand(commandString, con);
                cmd.Parameters.AddWithValue("@regNo", Convert.ToInt32(com_RegNo.Text));

                try
                {
                    //open database connection
                    con.Open();
                    DataTable dt = new DataTable();

                    //Execute non query commend
                    cmd.ExecuteNonQuery();

                    //show successful message
                    MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    //Show faliure message
                    MessageBox.Show("Delete Record Failed", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("error" + ex);
                }
                finally
                {
                    //Close the connection
                    con.Close();
                    //Reloard form back to initial state
                    ReLoadForm();
                }
            }
            else if (dr == DialogResult.No) ;
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
    }
    }

