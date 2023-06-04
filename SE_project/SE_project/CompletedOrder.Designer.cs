namespace SE_project
{
    partial class CompletedOrder
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
            lbCompletedDate = new Label();
            lbCompletedId = new Label();
            label2 = new Label();
            label1 = new Label();
            listbxCompletedTests = new ListBox();
            btnOrderDetails = new Button();
            SuspendLayout();
            // 
            // lbCompletedDate
            // 
            lbCompletedDate.AutoSize = true;
            lbCompletedDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCompletedDate.Location = new Point(158, 51);
            lbCompletedDate.Name = "lbCompletedDate";
            lbCompletedDate.Size = new Size(52, 21);
            lbCompletedDate.TabIndex = 8;
            lbCompletedDate.Text = "label5";
            // 
            // lbCompletedId
            // 
            lbCompletedId.AutoSize = true;
            lbCompletedId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCompletedId.Location = new Point(61, 17);
            lbCompletedId.Name = "lbCompletedId";
            lbCompletedId.Size = new Size(52, 21);
            lbCompletedId.TabIndex = 7;
            lbCompletedId.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 48);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 6;
            label2.Text = "Data złożenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // listbxCompletedTests
            // 
            listbxCompletedTests.FormattingEnabled = true;
            listbxCompletedTests.ItemHeight = 15;
            listbxCompletedTests.Location = new Point(296, 14);
            listbxCompletedTests.Name = "listbxCompletedTests";
            listbxCompletedTests.Size = new Size(120, 94);
            listbxCompletedTests.TabIndex = 9;
            // 
            // btnOrderDetails
            // 
            btnOrderDetails.Location = new Point(37, 82);
            btnOrderDetails.Name = "btnOrderDetails";
            btnOrderDetails.Size = new Size(148, 30);
            btnOrderDetails.TabIndex = 10;
            btnOrderDetails.Text = "Szczegóły";
            btnOrderDetails.UseVisualStyleBackColor = true;
            // 
            // CompletedOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOrderDetails);
            Controls.Add(listbxCompletedTests);
            Controls.Add(lbCompletedDate);
            Controls.Add(lbCompletedId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CompletedOrder";
            Size = new Size(428, 125);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCompletedDate;
        private Label lbCompletedId;
        private Label label2;
        private Label label1;
        private ListBox listbxCompletedTests;
        private Button btnOrderDetails;
    }
}
