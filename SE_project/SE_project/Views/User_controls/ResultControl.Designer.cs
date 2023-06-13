namespace SE_project.Views.User_controls
{
    partial class ResultControl
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
            lbName = new Label();
            lbResult = new Label();
            lbMin = new Label();
            lbMax = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(9, 10);
            lbName.Name = "lbName";
            lbName.Size = new Size(61, 25);
            lbName.TabIndex = 0;
            lbName.Text = "label1";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(9, 40);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(63, 25);
            lbResult.TabIndex = 1;
            lbResult.Text = "label2";
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbMin.Location = new Point(238, 10);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(63, 25);
            lbMin.TabIndex = 2;
            lbMin.Text = "label3";
            // 
            // lbMax
            // 
            lbMax.AutoSize = true;
            lbMax.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbMax.Location = new Point(238, 40);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(63, 25);
            lbMax.TabIndex = 3;
            lbMax.Text = "label4";
            // 
            // ResultControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbMax);
            Controls.Add(lbMin);
            Controls.Add(lbResult);
            Controls.Add(lbName);
            Name = "ResultControl";
            Size = new Size(363, 74);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbResult;
        private Label lbMin;
        private Label lbMax;
    }
}
