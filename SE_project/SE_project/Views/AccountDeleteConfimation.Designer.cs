namespace SE_project
{
    partial class AccountDeleteConfimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDeleteConfimation));
            txtbEmail = new TextBox();
            txtbLogin = new TextBox();
            txtbPassword = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(307, 156);
            txtbEmail.Margin = new Padding(4, 5, 4, 5);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(224, 31);
            txtbEmail.TabIndex = 0;
            // 
            // txtbLogin
            // 
            txtbLogin.Location = new Point(307, 204);
            txtbLogin.Margin = new Padding(4, 5, 4, 5);
            txtbLogin.Name = "txtbLogin";
            txtbLogin.Size = new Size(224, 31);
            txtbLogin.TabIndex = 1;
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(307, 252);
            txtbPassword.Margin = new Padding(4, 5, 4, 5);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.PasswordChar = '*';
            txtbPassword.Size = new Size(224, 31);
            txtbPassword.TabIndex = 2;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(134, 319);
            btnConfirm.Margin = new Padding(4, 5, 4, 5);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(169, 48);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Potwierdź";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(339, 319);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(638, 45);
            label1.TabIndex = 5;
            label1.Text = "Czy na pewno chcesz usunąć swoje konto?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(114, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(448, 40);
            label2.TabIndex = 6;
            label2.Text = "Ta operacja jest nieodwracalna!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 7;
            label3.Text = "Adres e-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 8;
            label4.Text = "Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(144, 253);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 9;
            label5.Text = "Hasło";
            // 
            // AccountDeleteConfimation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 407);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtbPassword);
            Controls.Add(txtbLogin);
            Controls.Add(txtbEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "AccountDeleteConfimation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potwierdzenie usunięcia konta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbEmail;
        private TextBox txtbLogin;
        private TextBox txtbPassword;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}