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
            vScrollBar1 = new VScrollBar();
            listbxCompletedTests = new ListBox();
            lbCompletedDate = new Label();
            lbCompletedId = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(384, 5);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(18, 64);
            vScrollBar1.TabIndex = 15;
            // 
            // listbxCompletedTests
            // 
            listbxCompletedTests.FormattingEnabled = true;
            listbxCompletedTests.ItemHeight = 15;
            listbxCompletedTests.Location = new Point(253, 5);
            listbxCompletedTests.Name = "listbxCompletedTests";
            listbxCompletedTests.Size = new Size(128, 64);
            listbxCompletedTests.TabIndex = 14;
            listbxCompletedTests.SelectedIndexChanged += listbxPedningTests_SelectedIndexChanged;
            // 
            // lbCompletedDate
            // 
            lbCompletedDate.AutoSize = true;
            lbCompletedDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbCompletedDate.Location = new Point(115, 25);
            lbCompletedDate.Name = "lbCompletedDate";
            lbCompletedDate.Size = new Size(45, 19);
            lbCompletedDate.TabIndex = 12;
            lbCompletedDate.Text = "label5";
            // 
            // lbCompletedId
            // 
            lbCompletedId.AutoSize = true;
            lbCompletedId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbCompletedId.Location = new Point(35, 5);
            lbCompletedId.Name = "lbCompletedId";
            lbCompletedId.Size = new Size(45, 19);
            lbCompletedId.TabIndex = 11;
            lbCompletedId.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 9;
            label2.Text = "Data złożenia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // button1
            // 
            button1.Location = new Point(51, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Szczegóły";
            button1.UseVisualStyleBackColor = true;
            // 
            // CompletedOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(vScrollBar1);
            Controls.Add(listbxCompletedTests);
            Controls.Add(lbCompletedDate);
            Controls.Add(lbCompletedId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CompletedOrder";
            Size = new Size(428, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private ListBox listbxCompletedTests;
        private Label lbCompletedDate;
        private Label lbCompletedId;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
