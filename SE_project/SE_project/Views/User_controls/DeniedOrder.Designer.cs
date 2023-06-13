namespace SE_project.Views.User_controls
{
    partial class DeniedOrder
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lbDeniedId = new Label();
            lbDeniedDate = new Label();
            listbxDeniedTests = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 27);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Data";
            // 
            // lbDeniedId
            // 
            lbDeniedId.AutoSize = true;
            lbDeniedId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDeniedId.Location = new Point(41, 6);
            lbDeniedId.Name = "lbDeniedId";
            lbDeniedId.Size = new Size(50, 20);
            lbDeniedId.TabIndex = 2;
            lbDeniedId.Text = "label3";
            // 
            // lbDeniedDate
            // 
            lbDeniedDate.AutoSize = true;
            lbDeniedDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDeniedDate.Location = new Point(58, 28);
            lbDeniedDate.Name = "lbDeniedDate";
            lbDeniedDate.Size = new Size(50, 20);
            lbDeniedDate.TabIndex = 3;
            lbDeniedDate.Text = "label4";
            // 
            // listbxDeniedTests
            // 
            listbxDeniedTests.FormattingEnabled = true;
            listbxDeniedTests.ItemHeight = 15;
            listbxDeniedTests.Location = new Point(298, 6);
            listbxDeniedTests.Name = "listbxDeniedTests";
            listbxDeniedTests.Size = new Size(132, 64);
            listbxDeniedTests.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(9, 49);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 5;
            label5.Text = "ODRZUCONO";
            // 
            // DeniedOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label5);
            Controls.Add(listbxDeniedTests);
            Controls.Add(lbDeniedDate);
            Controls.Add(lbDeniedId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeniedOrder";
            Size = new Size(435, 73);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbDeniedId;
        private Label lbDeniedDate;
        private ListBox listbxDeniedTests;
        private Label label5;
    }
}
