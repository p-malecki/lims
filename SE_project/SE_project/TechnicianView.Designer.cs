namespace SE_project
{
    partial class TechnicianView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianView));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            splitContainer3 = new SplitContainer();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnLogout = new Button();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            tabPage2 = new TabPage();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel3 = new Panel();
            label7 = new Label();
            splitContainer2 = new SplitContainer();
            button2 = new Button();
            groupBox2 = new GroupBox();
            textBox9 = new TextBox();
            label12 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1102, 705);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(splitContainer3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1094, 672);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "badania do akceptacji";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 113);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 45);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 0;
            label1.Text = "lista zamówień do akceptacji";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(listBox2);
            splitContainer3.Panel2.Controls.Add(btnLogout);
            splitContainer3.Panel2.Controls.Add(button4);
            splitContainer3.Panel2.Controls.Add(button3);
            splitContainer3.Panel2.Controls.Add(groupBox3);
            splitContainer3.Size = new Size(1088, 666);
            splitContainer3.SplitterDistance = 207;
            splitContainer3.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(-3, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 564);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(4, 1);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(240, 664);
            listBox2.TabIndex = 13;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(729, 2);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 27);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Wyloguj";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button4
            // 
            button4.Location = new Point(556, 364);
            button4.Name = "button4";
            button4.Size = new Size(132, 67);
            button4.TabIndex = 4;
            button4.Text = "odrzuć";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(331, 364);
            button3.Name = "button3";
            button3.Size = new Size(121, 67);
            button3.TabIndex = 3;
            button3.Text = "akceptuj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Location = new Point(298, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(343, 289);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "akceptacja badań";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(228, 232);
            label24.Name = "label24";
            label24.Size = new Size(58, 20);
            label24.TabIndex = 17;
            label24.Text = "label24";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(228, 200);
            label23.Name = "label23";
            label23.Size = new Size(58, 20);
            label23.TabIndex = 16;
            label23.Text = "label23";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(228, 140);
            label22.Name = "label22";
            label22.Size = new Size(58, 20);
            label22.TabIndex = 15;
            label22.Text = "label22";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(228, 103);
            label21.Name = "label21";
            label21.Size = new Size(58, 20);
            label21.TabIndex = 14;
            label21.Text = "label21";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(228, 71);
            label20.Name = "label20";
            label20.Size = new Size(58, 20);
            label20.TabIndex = 13;
            label20.Text = "label20";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(228, 40);
            label19.Name = "label19";
            label19.Size = new Size(58, 20);
            label19.TabIndex = 12;
            label19.Text = "label19";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(33, 103);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(131, 20);
            label18.TabIndex = 11;
            label18.Text = "status zamówienia";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(33, 71);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(123, 20);
            label17.TabIndex = 10;
            label17.Text = "data zamówienia";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 232);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 9;
            label14.Text = "typ testu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 140);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(60, 20);
            label13.TabIndex = 8;
            label13.Text = "ID testu";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 200);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(87, 20);
            label15.TabIndex = 7;
            label15.Text = "nazwa testu";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 40);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(108, 20);
            label16.TabIndex = 6;
            label16.Text = "ID zamówienia";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel3);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1094, 672);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "badania zaakceptowane";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(0, 114);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(485, 562);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 110);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 45);
            label7.Name = "label7";
            label7.Size = new Size(203, 20);
            label7.TabIndex = 0;
            label7.Text = "lista badań zaakceptowanych";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(1088, 666);
            splitContainer2.SplitterDistance = 482;
            splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(304, 451);
            button2.Name = "button2";
            button2.Size = new Size(143, 56);
            button2.TabIndex = 2;
            button2.Text = "zatwierdz";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(81, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "wprowadzanie danych";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(221, 235);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 188);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 13;
            label12.Text = "górna granica ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(221, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(221, 133);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(221, 89);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(221, 47);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 238);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 8;
            label8.Text = "wartość";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 92);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 7;
            label9.Text = "nazwa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 50);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 6;
            label10.Text = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 140);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 5;
            label11.Text = "dolna granica";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1094, 672);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "historia badań";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1088, 666);
            splitContainer1.SplitterDistance = 473;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(-7, 107);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(485, 562);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-7, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 110);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 43);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 0;
            label2.Text = "lista historii badań";
            // 
            // button1
            // 
            button1.Location = new Point(361, 370);
            button1.Name = "button1";
            button1.Size = new Size(143, 56);
            button1.TabIndex = 1;
            button1.Text = "zatwierdz";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(138, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "edycja badania";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(221, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 178);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 8;
            label6.Text = "zaaktualizowana wartość";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "nazwa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 6;
            label3.Text = "ID";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 129);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 5;
            label5.Text = "obecna wartość";
            label5.Click += label5_Click;
            // 
            // TechnicianView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 703);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "TechnicianView";
            Text = "LIS Technik";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel3;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox textBox9;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer3;
        private Button button2;
        private GroupBox groupBox3;
        private Label label15;
        private Label label16;
        private Button button4;
        private Button button3;
        private Button btnLogout;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label13;
        private Label label14;
        private Label label17;
        private Label label18;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
    }
}