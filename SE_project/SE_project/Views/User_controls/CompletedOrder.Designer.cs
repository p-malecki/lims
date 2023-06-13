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
            listbxCompletedTests = new ListBox();
            lbCompletedDate = new Label();
            lbCompletedId = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDetails = new Button();
            btnPDFGenerate = new Button();
            SuspendLayout();
            // 
            // listbxCompletedTests
            // 
            listbxCompletedTests.FormattingEnabled = true;
            listbxCompletedTests.ItemHeight = 15;
            listbxCompletedTests.Location = new Point(298, 6);
            listbxCompletedTests.Name = "listbxCompletedTests";
            listbxCompletedTests.Size = new Size(132, 64);
            listbxCompletedTests.TabIndex = 14;
            // 
            // lbCompletedDate
            // 
            lbCompletedDate.AutoSize = true;
            lbCompletedDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbCompletedDate.Location = new Point(58, 37);
            lbCompletedDate.Name = "lbCompletedDate";
            lbCompletedDate.Size = new Size(50, 20);
            lbCompletedDate.TabIndex = 12;
            lbCompletedDate.Text = "label5";
            // 
            // lbCompletedId
            // 
            lbCompletedId.AutoSize = true;
            lbCompletedId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbCompletedId.Location = new Point(41, 16);
            lbCompletedId.Name = "lbCompletedId";
            lbCompletedId.Size = new Size(50, 20);
            lbCompletedId.TabIndex = 11;
            lbCompletedId.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 36);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 9;
            label2.Text = "Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(203, 7);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(91, 29);
            btnDetails.TabIndex = 16;
            btnDetails.Text = "Szczegóły";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnPDFGenerate
            // 
            btnPDFGenerate.Location = new Point(203, 40);
            btnPDFGenerate.Name = "btnPDFGenerate";
            btnPDFGenerate.Size = new Size(91, 29);
            btnPDFGenerate.TabIndex = 17;
            btnPDFGenerate.Text = "Raport PDF";
            btnPDFGenerate.UseVisualStyleBackColor = true;
            // 
            // CompletedOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnPDFGenerate);
            Controls.Add(btnDetails);
            Controls.Add(listbxCompletedTests);
            Controls.Add(lbCompletedDate);
            Controls.Add(lbCompletedId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CompletedOrder";
            Size = new Size(435, 73);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listbxCompletedTests;
        private Label lbCompletedDate;
        private Label lbCompletedId;
        private Label label2;
        private Label label1;
        private Button btnDetails;
        private Button btnPDFGenerate;
    }
}
