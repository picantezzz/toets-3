namespace toets_3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnfactuurmaken = new Button();
            btnfactuurlijn = new Button();
            txtfactuurid = new TextBox();
            txtnaamklant = new TextBox();
            txtklantnummer = new TextBox();
            txtproduct = new TextBox();
            txtaantal = new TextBox();
            txtprijs = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 112);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Factuur id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 162);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Naam klant:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 227);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Klantnummer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(749, 139);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(749, 254);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "prijs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(749, 189);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "Aantal";
            // 
            // btnfactuurmaken
            // 
            btnfactuurmaken.Location = new Point(35, 287);
            btnfactuurmaken.Name = "btnfactuurmaken";
            btnfactuurmaken.Size = new Size(171, 29);
            btnfactuurmaken.TabIndex = 6;
            btnfactuurmaken.Text = "Maak factuur aan";
            btnfactuurmaken.UseVisualStyleBackColor = true;
            btnfactuurmaken.Click += btnfactuurmaken_Click;
            // 
            // btnfactuurlijn
            // 
            btnfactuurlijn.Location = new Point(707, 316);
            btnfactuurlijn.Name = "btnfactuurlijn";
            btnfactuurlijn.Size = new Size(180, 27);
            btnfactuurlijn.TabIndex = 7;
            btnfactuurlijn.Text = "Maak factuurlijn aan";
            btnfactuurlijn.UseVisualStyleBackColor = true;
            btnfactuurlijn.Click += btnfactuurlijn_Click;
            // 
            // txtfactuurid
            // 
            txtfactuurid.Location = new Point(149, 112);
            txtfactuurid.Name = "txtfactuurid";
            txtfactuurid.Size = new Size(125, 27);
            txtfactuurid.TabIndex = 8;
            // 
            // txtnaamklant
            // 
            txtnaamklant.Location = new Point(149, 155);
            txtnaamklant.Name = "txtnaamklant";
            txtnaamklant.Size = new Size(125, 27);
            txtnaamklant.TabIndex = 9;
            txtnaamklant.TextChanged += txtnaamklant_TextChanged;
            // 
            // txtklantnummer
            // 
            txtklantnummer.Location = new Point(149, 220);
            txtklantnummer.Name = "txtklantnummer";
            txtklantnummer.Size = new Size(125, 27);
            txtklantnummer.TabIndex = 10;
            // 
            // txtproduct
            // 
            txtproduct.Location = new Point(847, 139);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(125, 27);
            txtproduct.TabIndex = 11;
            txtproduct.TextChanged += txtproduct_TextChanged;
            // 
            // txtaantal
            // 
            txtaantal.Location = new Point(847, 189);
            txtaantal.Name = "txtaantal";
            txtaantal.Size = new Size(125, 27);
            txtaantal.TabIndex = 12;
            txtaantal.TextChanged += txtaantal_TextChanged;
            // 
            // txtprijs
            // 
            txtprijs.Location = new Point(847, 254);
            txtprijs.Name = "txtprijs";
            txtprijs.Size = new Size(125, 27);
            txtprijs.TabIndex = 13;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(35, 356);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(310, 144);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(707, 356);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(310, 144);
            listBox2.TabIndex = 15;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 35);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 16;
            label7.Text = "Factuur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(860, 35);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 17;
            label8.Text = "FactuurLijn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 544);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txtprijs);
            Controls.Add(txtaantal);
            Controls.Add(txtproduct);
            Controls.Add(txtklantnummer);
            Controls.Add(txtnaamklant);
            Controls.Add(txtfactuurid);
            Controls.Add(btnfactuurlijn);
            Controls.Add(btnfactuurmaken);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnfactuurmaken;
        private Button btnfactuurlijn;
        private TextBox txtfactuurid;
        private TextBox txtnaamklant;
        private TextBox txtklantnummer;
        private TextBox txtproduct;
        private TextBox txtaantal;
        private TextBox txtprijs;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label7;
        private Label label8;
    }
}
