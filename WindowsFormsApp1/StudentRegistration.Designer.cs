
namespace WindowsFormsApp1
{
    partial class StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistration));
            this.grp_StudentRegistration = new System.Windows.Forms.GroupBox();
            this.com_RegNo = new System.Windows.Forms.ComboBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_RegNo = new System.Windows.Forms.Label();
            this.grp_ParentDetails = new System.Windows.Forms.GroupBox();
            this.txt_ContactNumber = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_ParentName = new System.Windows.Forms.TextBox();
            this.lbl_ContactNumber = new System.Windows.Forms.Label();
            this.lbl_NIC = new System.Windows.Forms.Label();
            this.lbl_ParentName = new System.Windows.Forms.Label();
            this.grp_BasicDetails = new System.Windows.Forms.GroupBox();
            this.pkr_DateofBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.opt_Female = new System.Windows.Forms.RadioButton();
            this.opt_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_DateofBirth = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.grp_ContactDetails = new System.Windows.Forms.GroupBox();
            this.txt_HomePhone = new System.Windows.Forms.TextBox();
            this.txt_MobilePhone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_HomePhone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_MobilePhone = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lnk_Logout = new System.Windows.Forms.LinkLabel();
            this.lnk_Exit = new System.Windows.Forms.LinkLabel();
            this.grp_StudentRegistration.SuspendLayout();
            this.grp_ParentDetails.SuspendLayout();
            this.grp_BasicDetails.SuspendLayout();
            this.grp_ContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_StudentRegistration
            // 
            this.grp_StudentRegistration.BackColor = System.Drawing.Color.Transparent;
            this.grp_StudentRegistration.Controls.Add(this.com_RegNo);
            this.grp_StudentRegistration.Controls.Add(this.btn_Register);
            this.grp_StudentRegistration.Controls.Add(this.btn_Clear);
            this.grp_StudentRegistration.Controls.Add(this.btn_Delete);
            this.grp_StudentRegistration.Controls.Add(this.btn_Update);
            this.grp_StudentRegistration.Controls.Add(this.lbl_RegNo);
            this.grp_StudentRegistration.Controls.Add(this.grp_ParentDetails);
            this.grp_StudentRegistration.Controls.Add(this.grp_BasicDetails);
            this.grp_StudentRegistration.Controls.Add(this.grp_ContactDetails);
            this.grp_StudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_StudentRegistration.Location = new System.Drawing.Point(12, 87);
            this.grp_StudentRegistration.Name = "grp_StudentRegistration";
            this.grp_StudentRegistration.Size = new System.Drawing.Size(630, 706);
            this.grp_StudentRegistration.TabIndex = 6;
            this.grp_StudentRegistration.TabStop = false;
            this.grp_StudentRegistration.Text = "Student Registration ";
            // 
            // com_RegNo
            // 
            this.com_RegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_RegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_RegNo.FormattingEnabled = true;
            this.com_RegNo.Location = new System.Drawing.Point(185, 34);
            this.com_RegNo.Name = "com_RegNo";
            this.com_RegNo.Size = new System.Drawing.Size(193, 26);
            this.com_RegNo.TabIndex = 10;
            this.com_RegNo.SelectedIndexChanged += new System.EventHandler(this.com_RegNo_SelectedIndexChanged);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(18, 663);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(110, 37);
            this.btn_Register.TabIndex = 9;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(427, 663);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 37);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(519, 663);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 37);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(134, 663);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(112, 37);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_RegNo
            // 
            this.lbl_RegNo.AutoSize = true;
            this.lbl_RegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegNo.Location = new System.Drawing.Point(48, 37);
            this.lbl_RegNo.Name = "lbl_RegNo";
            this.lbl_RegNo.Size = new System.Drawing.Size(65, 18);
            this.lbl_RegNo.TabIndex = 4;
            this.lbl_RegNo.Text = "Reg No";
            this.lbl_RegNo.Click += new System.EventHandler(this.lbl_RegNo_Click);
            // 
            // grp_ParentDetails
            // 
            this.grp_ParentDetails.Controls.Add(this.txt_ContactNumber);
            this.grp_ParentDetails.Controls.Add(this.txt_NIC);
            this.grp_ParentDetails.Controls.Add(this.txt_ParentName);
            this.grp_ParentDetails.Controls.Add(this.lbl_ContactNumber);
            this.grp_ParentDetails.Controls.Add(this.lbl_NIC);
            this.grp_ParentDetails.Controls.Add(this.lbl_ParentName);
            this.grp_ParentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ParentDetails.Location = new System.Drawing.Point(18, 499);
            this.grp_ParentDetails.Name = "grp_ParentDetails";
            this.grp_ParentDetails.Size = new System.Drawing.Size(592, 155);
            this.grp_ParentDetails.TabIndex = 3;
            this.grp_ParentDetails.TabStop = false;
            this.grp_ParentDetails.Text = "Parent Details ";
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContactNumber.Location = new System.Drawing.Point(167, 113);
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.ReadOnly = true;
            this.txt_ContactNumber.Size = new System.Drawing.Size(137, 24);
            this.txt_ContactNumber.TabIndex = 12;
            // 
            // txt_NIC
            // 
            this.txt_NIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIC.Location = new System.Drawing.Point(167, 74);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.ReadOnly = true;
            this.txt_NIC.Size = new System.Drawing.Size(137, 24);
            this.txt_NIC.TabIndex = 9;
            // 
            // txt_ParentName
            // 
            this.txt_ParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ParentName.Location = new System.Drawing.Point(167, 35);
            this.txt_ParentName.Name = "txt_ParentName";
            this.txt_ParentName.ReadOnly = true;
            this.txt_ParentName.Size = new System.Drawing.Size(343, 24);
            this.txt_ParentName.TabIndex = 8;
            this.txt_ParentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_ContactNumber
            // 
            this.lbl_ContactNumber.AutoSize = true;
            this.lbl_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactNumber.Location = new System.Drawing.Point(30, 117);
            this.lbl_ContactNumber.Name = "lbl_ContactNumber";
            this.lbl_ContactNumber.Size = new System.Drawing.Size(131, 18);
            this.lbl_ContactNumber.TabIndex = 6;
            this.lbl_ContactNumber.Text = "Contact Number";
            // 
            // lbl_NIC
            // 
            this.lbl_NIC.AutoSize = true;
            this.lbl_NIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NIC.Location = new System.Drawing.Point(31, 77);
            this.lbl_NIC.Name = "lbl_NIC";
            this.lbl_NIC.Size = new System.Drawing.Size(36, 18);
            this.lbl_NIC.TabIndex = 5;
            this.lbl_NIC.Text = "NIC";
            // 
            // lbl_ParentName
            // 
            this.lbl_ParentName.AutoSize = true;
            this.lbl_ParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParentName.Location = new System.Drawing.Point(30, 38);
            this.lbl_ParentName.Name = "lbl_ParentName";
            this.lbl_ParentName.Size = new System.Drawing.Size(106, 18);
            this.lbl_ParentName.TabIndex = 4;
            this.lbl_ParentName.Text = "Parent Name";
            this.lbl_ParentName.Click += new System.EventHandler(this.lbl_ParentName_Click);
            // 
            // grp_BasicDetails
            // 
            this.grp_BasicDetails.Controls.Add(this.pkr_DateofBirth);
            this.grp_BasicDetails.Controls.Add(this.txt_LastName);
            this.grp_BasicDetails.Controls.Add(this.txt_FirstName);
            this.grp_BasicDetails.Controls.Add(this.opt_Female);
            this.grp_BasicDetails.Controls.Add(this.opt_Male);
            this.grp_BasicDetails.Controls.Add(this.lbl_Gender);
            this.grp_BasicDetails.Controls.Add(this.lbl_DateofBirth);
            this.grp_BasicDetails.Controls.Add(this.lbl_LastName);
            this.grp_BasicDetails.Controls.Add(this.lbl_FirstName);
            this.grp_BasicDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BasicDetails.Location = new System.Drawing.Point(18, 78);
            this.grp_BasicDetails.Name = "grp_BasicDetails";
            this.grp_BasicDetails.Size = new System.Drawing.Size(592, 196);
            this.grp_BasicDetails.TabIndex = 1;
            this.grp_BasicDetails.TabStop = false;
            this.grp_BasicDetails.Text = "Basic Details";
            // 
            // pkr_DateofBirth
            // 
            this.pkr_DateofBirth.Enabled = false;
            this.pkr_DateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkr_DateofBirth.Location = new System.Drawing.Point(167, 102);
            this.pkr_DateofBirth.Name = "pkr_DateofBirth";
            this.pkr_DateofBirth.Size = new System.Drawing.Size(290, 24);
            this.pkr_DateofBirth.TabIndex = 8;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(167, 64);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            this.txt_LastName.Size = new System.Drawing.Size(343, 24);
            this.txt_LastName.TabIndex = 7;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(167, 30);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.ReadOnly = true;
            this.txt_FirstName.Size = new System.Drawing.Size(343, 24);
            this.txt_FirstName.TabIndex = 0;
            // 
            // opt_Female
            // 
            this.opt_Female.AutoSize = true;
            this.opt_Female.Enabled = false;
            this.opt_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Female.Location = new System.Drawing.Point(267, 150);
            this.opt_Female.Name = "opt_Female";
            this.opt_Female.Size = new System.Drawing.Size(81, 22);
            this.opt_Female.TabIndex = 5;
            this.opt_Female.TabStop = true;
            this.opt_Female.Text = "Female";
            this.opt_Female.UseVisualStyleBackColor = true;
            this.opt_Female.CheckedChanged += new System.EventHandler(this.opt_Female_CheckedChanged);
            // 
            // opt_Male
            // 
            this.opt_Male.AutoSize = true;
            this.opt_Male.Enabled = false;
            this.opt_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_Male.Location = new System.Drawing.Point(167, 150);
            this.opt_Male.Name = "opt_Male";
            this.opt_Male.Size = new System.Drawing.Size(62, 22);
            this.opt_Male.TabIndex = 4;
            this.opt_Male.TabStop = true;
            this.opt_Male.Text = "Male";
            this.opt_Male.UseVisualStyleBackColor = true;
            this.opt_Male.CheckedChanged += new System.EventHandler(this.opt_Male_CheckedChanged);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(30, 152);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(63, 18);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_DateofBirth
            // 
            this.lbl_DateofBirth.AutoSize = true;
            this.lbl_DateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateofBirth.Location = new System.Drawing.Point(30, 108);
            this.lbl_DateofBirth.Name = "lbl_DateofBirth";
            this.lbl_DateofBirth.Size = new System.Drawing.Size(103, 18);
            this.lbl_DateofBirth.TabIndex = 2;
            this.lbl_DateofBirth.Text = "Date of Birth";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(30, 68);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(89, 18);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(31, 34);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(91, 18);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "First Name";
            this.lbl_FirstName.Click += new System.EventHandler(this.lbl_FirstName_Click);
            // 
            // grp_ContactDetails
            // 
            this.grp_ContactDetails.Controls.Add(this.txt_HomePhone);
            this.grp_ContactDetails.Controls.Add(this.txt_MobilePhone);
            this.grp_ContactDetails.Controls.Add(this.txt_Email);
            this.grp_ContactDetails.Controls.Add(this.txt_Address);
            this.grp_ContactDetails.Controls.Add(this.lbl_HomePhone);
            this.grp_ContactDetails.Controls.Add(this.lbl_Email);
            this.grp_ContactDetails.Controls.Add(this.lbl_MobilePhone);
            this.grp_ContactDetails.Controls.Add(this.lbl_Address);
            this.grp_ContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ContactDetails.Location = new System.Drawing.Point(18, 300);
            this.grp_ContactDetails.Name = "grp_ContactDetails";
            this.grp_ContactDetails.Size = new System.Drawing.Size(592, 176);
            this.grp_ContactDetails.TabIndex = 2;
            this.grp_ContactDetails.TabStop = false;
            this.grp_ContactDetails.Text = "Contact Details";
            // 
            // txt_HomePhone
            // 
            this.txt_HomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomePhone.Location = new System.Drawing.Point(438, 133);
            this.txt_HomePhone.Name = "txt_HomePhone";
            this.txt_HomePhone.ReadOnly = true;
            this.txt_HomePhone.Size = new System.Drawing.Size(148, 24);
            this.txt_HomePhone.TabIndex = 12;
            // 
            // txt_MobilePhone
            // 
            this.txt_MobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MobilePhone.Location = new System.Drawing.Point(167, 133);
            this.txt_MobilePhone.Name = "txt_MobilePhone";
            this.txt_MobilePhone.ReadOnly = true;
            this.txt_MobilePhone.Size = new System.Drawing.Size(137, 24);
            this.txt_MobilePhone.TabIndex = 11;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(167, 90);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(193, 24);
            this.txt_Email.TabIndex = 10;
            this.txt_Email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(167, 31);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(400, 50);
            this.txt_Address.TabIndex = 9;
            this.txt_Address.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_HomePhone
            // 
            this.lbl_HomePhone.AutoSize = true;
            this.lbl_HomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomePhone.Location = new System.Drawing.Point(327, 136);
            this.lbl_HomePhone.Name = "lbl_HomePhone";
            this.lbl_HomePhone.Size = new System.Drawing.Size(106, 18);
            this.lbl_HomePhone.TabIndex = 7;
            this.lbl_HomePhone.Text = "Home Phone";
            this.lbl_HomePhone.Click += new System.EventHandler(this.lbl_HomePhone_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(31, 93);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(50, 18);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_MobilePhone
            // 
            this.lbl_MobilePhone.AutoSize = true;
            this.lbl_MobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobilePhone.Location = new System.Drawing.Point(30, 136);
            this.lbl_MobilePhone.Name = "lbl_MobilePhone";
            this.lbl_MobilePhone.Size = new System.Drawing.Size(111, 18);
            this.lbl_MobilePhone.TabIndex = 5;
            this.lbl_MobilePhone.Text = "Mobile Phone";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(30, 34);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(69, 18);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(137, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(368, 50);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Skills International";
            // 
            // lnk_Logout
            // 
            this.lnk_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_Logout.Location = new System.Drawing.Point(12, 9);
            this.lnk_Logout.Name = "lnk_Logout";
            this.lnk_Logout.Size = new System.Drawing.Size(100, 35);
            this.lnk_Logout.TabIndex = 2;
            this.lnk_Logout.TabStop = true;
            this.lnk_Logout.Text = "Logout";
            this.lnk_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Logout_LinkClicked);
            // 
            // lnk_Exit
            // 
            this.lnk_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_Exit.Location = new System.Drawing.Point(594, 809);
            this.lnk_Exit.Name = "lnk_Exit";
            this.lnk_Exit.Size = new System.Drawing.Size(100, 29);
            this.lnk_Exit.TabIndex = 3;
            this.lnk_Exit.TabStop = true;
            this.lnk_Exit.Text = "Exit";
            this.lnk_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Exit_LinkClicked);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(654, 838);
            this.Controls.Add(this.lnk_Exit);
            this.Controls.Add(this.lnk_Logout);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grp_StudentRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.grp_StudentRegistration.ResumeLayout(false);
            this.grp_StudentRegistration.PerformLayout();
            this.grp_ParentDetails.ResumeLayout(false);
            this.grp_ParentDetails.PerformLayout();
            this.grp_BasicDetails.ResumeLayout(false);
            this.grp_BasicDetails.PerformLayout();
            this.grp_ContactDetails.ResumeLayout(false);
            this.grp_ContactDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_StudentRegistration;
        private System.Windows.Forms.GroupBox grp_BasicDetails;
        private System.Windows.Forms.GroupBox grp_ContactDetails;
        private System.Windows.Forms.GroupBox grp_ParentDetails;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_RegNo;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_DateofBirth;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_ContactNumber;
        private System.Windows.Forms.Label lbl_NIC;
        private System.Windows.Forms.Label lbl_ParentName;
        private System.Windows.Forms.Label lbl_HomePhone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_MobilePhone;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.ComboBox com_RegNo;
        private System.Windows.Forms.RadioButton opt_Female;
        private System.Windows.Forms.RadioButton opt_Male;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_HomePhone;
        private System.Windows.Forms.TextBox txt_MobilePhone;
        private System.Windows.Forms.TextBox txt_ContactNumber;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_ParentName;
        private System.Windows.Forms.DateTimePicker pkr_DateofBirth;
        private System.Windows.Forms.LinkLabel lnk_Logout;
        private System.Windows.Forms.LinkLabel lnk_Exit;
    }
}