namespace CalculatriceFacture
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            listBox3 = new ListBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Insérer le %";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(241, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 169);
            listBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Montant";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown_1;
            // 
            // button4
            // 
            button4.Location = new Point(134, 92);
            button4.Name = "button4";
            button4.Size = new Size(92, 61);
            button4.TabIndex = 6;
            button4.Text = "Ajouter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(23, 169);
            button5.Name = "button5";
            button5.Size = new Size(203, 51);
            button5.TabIndex = 7;
            button5.Text = "Calculer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(134, 12);
            button7.Name = "button7";
            button7.Size = new Size(92, 61);
            button7.TabIndex = 9;
            button7.Text = "Appliquer";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(35, 312);
            button8.Name = "button8";
            button8.Size = new Size(175, 53);
            button8.TabIndex = 10;
            button8.Text = "Reset";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(241, 196);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(195, 169);
            listBox3.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 23);
            textBox3.TabIndex = 13;
            textBox3.Text = "Résultat:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(448, 379);
            Controls.Add(textBox3);
            Controls.Add(listBox3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private ListBox listBox3;
        private TextBox textBox3;
    }
}
