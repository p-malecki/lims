namespace SE_project
{
    partial class PendingOrder
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
            label3 = new Label();
            lbPendingDate = new Label();
            lbPendingStatus = new Label();
            listbxPedningTests = new ListBox();
            lbPendingId = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 48);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // lbPendingDate
            // 
            lbPendingDate.AutoSize = true;
            lbPendingDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPendingDate.Location = new Point(58, 28);
            lbPendingDate.Name = "lbPendingDate";
            lbPendingDate.Size = new Size(50, 20);
            lbPendingDate.TabIndex = 4;
            lbPendingDate.Text = "label5";
            // 
            // lbPendingStatus
            // 
            lbPendingStatus.AutoSize = true;
            lbPendingStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPendingStatus.Location = new Point(70, 49);
            lbPendingStatus.Name = "lbPendingStatus";
            lbPendingStatus.Size = new Size(50, 20);
            lbPendingStatus.TabIndex = 5;
            lbPendingStatus.Text = "label6";
            // 
            // listbxPedningTests
            // 
            listbxPedningTests.FormattingEnabled = true;
            listbxPedningTests.ItemHeight = 15;
            listbxPedningTests.Location = new Point(299, 7);
            listbxPedningTests.Name = "listbxPedningTests";
            listbxPedningTests.Size = new Size(132, 64);
            listbxPedningTests.TabIndex = 6;
            // 
            // lbPendingId
            // 
            lbPendingId.AutoSize = true;
            lbPendingId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPendingId.Location = new Point(41, 7);
            lbPendingId.Name = "lbPendingId";
            lbPendingId.Size = new Size(50, 20);
            lbPendingId.TabIndex = 3;
            lbPendingId.Text = "label4";
            // 
            // PendingOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(listbxPedningTests);
            Controls.Add(lbPendingStatus);
            Controls.Add(lbPendingDate);
            Controls.Add(lbPendingId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PendingOrder";
            Size = new Size(436, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbPendingDate;
        private Label lbPendingStatus;
        private ListBox listbxPedningTests;
        private Label lbPendingId;
    }
}
