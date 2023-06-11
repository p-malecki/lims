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
            lbPendingId = new Label();
            lbPendingDate = new Label();
            lbPendingStatus = new Label();
            listbxPedningTests = new ListBox();
            vScrollBar1 = new VScrollBar();
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
            label2.Size = new Size(106, 21);
            label2.TabIndex = 1;
            label2.Text = "Data złożenia";
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
            // lbPendingId
            // 
            lbPendingId.AutoSize = true;
            lbPendingId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPendingId.Location = new Point(41, 8);
            lbPendingId.Name = "lbPendingId";
            lbPendingId.Size = new Size(45, 19);
            lbPendingId.TabIndex = 3;
            lbPendingId.Text = "label4";
            // 
            // lbPendingDate
            // 
            lbPendingDate.AutoSize = true;
            lbPendingDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPendingDate.Location = new Point(121, 28);
            lbPendingDate.Name = "lbPendingDate";
            lbPendingDate.Size = new Size(45, 19);
            lbPendingDate.TabIndex = 4;
            lbPendingDate.Text = "label5";
            // 
            // lbPendingStatus
            // 
            lbPendingStatus.AutoSize = true;
            lbPendingStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPendingStatus.Location = new Point(70, 49);
            lbPendingStatus.Name = "lbPendingStatus";
            lbPendingStatus.Size = new Size(45, 19);
            lbPendingStatus.TabIndex = 5;
            lbPendingStatus.Text = "label6";
            // 
            // listbxPedningTests
            // 
            listbxPedningTests.FormattingEnabled = true;
            listbxPedningTests.ItemHeight = 15;
            listbxPedningTests.Location = new Point(259, 8);
            listbxPedningTests.Name = "listbxPedningTests";
            listbxPedningTests.Size = new Size(128, 64);
            listbxPedningTests.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(390, 8);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(18, 64);
            vScrollBar1.TabIndex = 7;
            // 
            // PendingOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vScrollBar1);
            Controls.Add(listbxPedningTests);
            Controls.Add(lbPendingStatus);
            Controls.Add(lbPendingDate);
            Controls.Add(lbPendingId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PendingOrder";
            Size = new Size(428, 77);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbPendingId;
        private Label lbPendingDate;
        private Label lbPendingStatus;
        private ListBox listbxPedningTests;
        private VScrollBar vScrollBar1;
    }
}
