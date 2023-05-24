namespace SE_project
{
    partial class LoginRegisterView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbLoginType = new ComboBox();
            label1 = new Label();
            txtbLogin = new TextBox();
            txtbPasssword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtbNewAddress = new TextBox();
            label10 = new Label();
            numNewBirthdateYear = new NumericUpDown();
            numNewBirthdateMonth = new NumericUpDown();
            numNewBirthdateDay = new NumericUpDown();
            label9 = new Label();
            txtbNewSurname = new TextBox();
            label8 = new Label();
            txtbNewPesel = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtbNewName = new TextBox();
            txtbNewLogin = new TextBox();
            btnSignUp = new Button();
            label4 = new Label();
            label6 = new Label();
            txtbNewPassword = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNewBirthdateYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNewBirthdateMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNewBirthdateDay).BeginInit();
            SuspendLayout();
            // 
            // cbLoginType
            // 
            cbLoginType.FormattingEnabled = true;
            cbLoginType.Items.AddRange(new object[] { "Klient", "Technik laboratoryjny", "Administrator" });
            cbLoginType.Location = new Point(268, 296);
            cbLoginType.Name = "cbLoginType";
            cbLoginType.Size = new Size(281, 38);
            cbLoginType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 296);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 1;
            label1.Text = "typ konta";
            // 
            // txtbLogin
            // 
            txtbLogin.Location = new Point(245, 172);
            txtbLogin.Name = "txtbLogin";
            txtbLogin.Size = new Size(304, 35);
            txtbLogin.TabIndex = 2;
            txtbLogin.Text = "login";
            // 
            // txtbPasssword
            // 
            txtbPasssword.Location = new Point(245, 235);
            txtbPasssword.Name = "txtbPasssword";
            txtbPasssword.Size = new Size(304, 35);
            txtbPasssword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(137, 172);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 4;
            label2.Text = "login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(137, 235);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 5;
            label3.Text = "hasło";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(217, 385);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 52);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Zaloguj";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(743, 700);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(txtbLogin);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(cbLoginType);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtbPasssword);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(735, 657);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Logowanie";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(txtbNewAddress);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(numNewBirthdateYear);
            tabPage2.Controls.Add(numNewBirthdateMonth);
            tabPage2.Controls.Add(numNewBirthdateDay);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtbNewSurname);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtbNewPesel);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtbNewName);
            tabPage2.Controls.Add(txtbNewLogin);
            tabPage2.Controls.Add(btnSignUp);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtbNewPassword);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(735, 657);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rejestracja";
            // 
            // txtbNewAddress
            // 
            txtbNewAddress.Location = new Point(332, 407);
            txtbNewAddress.Name = "txtbNewAddress";
            txtbNewAddress.Size = new Size(290, 35);
            txtbNewAddress.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(117, 407);
            label10.Name = "label10";
            label10.Size = new Size(200, 30);
            label10.TabIndex = 31;
            label10.Text = "adres zamieszkania";
            // 
            // numNewBirthdateYear
            // 
            numNewBirthdateYear.Location = new Point(523, 304);
            numNewBirthdateYear.Name = "numNewBirthdateYear";
            numNewBirthdateYear.Size = new Size(99, 35);
            numNewBirthdateYear.TabIndex = 30;
            // 
            // numNewBirthdateMonth
            // 
            numNewBirthdateMonth.Location = new Point(426, 304);
            numNewBirthdateMonth.Name = "numNewBirthdateMonth";
            numNewBirthdateMonth.Size = new Size(74, 35);
            numNewBirthdateMonth.TabIndex = 29;
            // 
            // numNewBirthdateDay
            // 
            numNewBirthdateDay.Location = new Point(332, 304);
            numNewBirthdateDay.Name = "numNewBirthdateDay";
            numNewBirthdateDay.Size = new Size(74, 35);
            numNewBirthdateDay.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(117, 256);
            label9.Name = "label9";
            label9.Size = new Size(104, 30);
            label9.TabIndex = 27;
            label9.Text = "nazwisko";
            // 
            // txtbNewSurname
            // 
            txtbNewSurname.Location = new Point(332, 253);
            txtbNewSurname.Name = "txtbNewSurname";
            txtbNewSurname.Size = new Size(290, 35);
            txtbNewSurname.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(117, 357);
            label8.Name = "label8";
            label8.Size = new Size(71, 30);
            label8.TabIndex = 25;
            label8.Text = "PESEL";
            // 
            // txtbNewPesel
            // 
            txtbNewPesel.Location = new Point(332, 357);
            txtbNewPesel.Name = "txtbNewPesel";
            txtbNewPesel.Size = new Size(290, 35);
            txtbNewPesel.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(114, 304);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 23;
            label7.Text = "data urodzenia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(117, 209);
            label5.Name = "label5";
            label5.Size = new Size(55, 30);
            label5.TabIndex = 21;
            label5.Text = "imię";
            // 
            // txtbNewName
            // 
            txtbNewName.Location = new Point(332, 204);
            txtbNewName.Name = "txtbNewName";
            txtbNewName.Size = new Size(290, 35);
            txtbNewName.TabIndex = 20;
            // 
            // txtbNewLogin
            // 
            txtbNewLogin.Location = new Point(332, 105);
            txtbNewLogin.Name = "txtbNewLogin";
            txtbNewLogin.Size = new Size(290, 35);
            txtbNewLogin.TabIndex = 9;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(192, 480);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(366, 52);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "Zarejestruj";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(117, 158);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 12;
            label4.Text = "hasło";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(114, 108);
            label6.Name = "label6";
            label6.Size = new Size(64, 30);
            label6.TabIndex = 11;
            label6.Text = "login";
            // 
            // txtbNewPassword
            // 
            txtbNewPassword.Location = new Point(332, 155);
            txtbNewPassword.Name = "txtbNewPassword";
            txtbNewPassword.Size = new Size(290, 35);
            txtbNewPassword.TabIndex = 10;
            // 
            // LoginRegisterView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 650);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginRegisterView";
            Text = "LIS";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNewBirthdateYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNewBirthdateMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNewBirthdateDay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbLoginType;
        private Label label1;
        private TextBox txtbLogin;
        private TextBox txtbPasssword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSignUp;
        private Label label4;
        private Label label6;
        private TextBox txtbNewPassword;
        private TextBox txtbNewLogin;
        private Label label8;
        private TextBox txtbNewPesel;
        private Label label7;
        private Label label5;
        private TextBox txtbNewName;
        private Label label9;
        private TextBox txtbNewSurname;
        private NumericUpDown numNewBirthdateYear;
        private NumericUpDown numNewBirthdateMonth;
        private NumericUpDown numNewBirthdateDay;
        private TextBox txtbNewAddress;
        private Label label10;
    }
}