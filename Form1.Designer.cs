namespace graphic_test
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.letter_chosen = new System.Windows.Forms.TextBox();
            this.word = new System.Windows.Forms.Label();
            this.argument = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label_a = new System.Windows.Forms.Label();
            this.final_word = new System.Windows.Forms.Label();
            this.error_handler = new System.Windows.Forms.Label();
            this.n_lives = new System.Windows.Forms.Label();
            this.guess_word = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // letter_chosen
            // 
            this.letter_chosen.Location = new System.Drawing.Point(231, 335);
            this.letter_chosen.Name = "letter_chosen";
            this.letter_chosen.Size = new System.Drawing.Size(214, 20);
            this.letter_chosen.TabIndex = 0;
            this.letter_chosen.TextChanged += new System.EventHandler(this.letter_chosen_TextChanged);
            // 
            // word
            // 
            this.word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.word.Font = new System.Drawing.Font("Playbill", 40F);
            this.word.Location = new System.Drawing.Point(33, 248);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(631, 55);
            this.word.TabIndex = 1;
            this.word.Text = "Select the difficulty by pressing the checkboxes";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // argument
            // 
            this.argument.Font = new System.Drawing.Font("OCR A Extended", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argument.Location = new System.Drawing.Point(120, 303);
            this.argument.Name = "argument";
            this.argument.Size = new System.Drawing.Size(438, 29);
            this.argument.TabIndex = 2;
            this.argument.Text = "the category chosen is...";
            this.argument.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(256, 380);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(155, 59);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.conferm_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(43, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 33);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Easy";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(43, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 33);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Medium";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(43, 154);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(176, 33);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Difficult";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(49, 342);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(81, 13);
            this.label_a.TabIndex = 8;
            this.label_a.Text = "number of lives:";
            this.label_a.Click += new System.EventHandler(this.label_a_Click);
            // 
            // final_word
            // 
            this.final_word.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_word.Location = new System.Drawing.Point(139, 192);
            this.final_word.Name = "final_word";
            this.final_word.Size = new System.Drawing.Size(391, 44);
            this.final_word.TabIndex = 9;
            this.final_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // error_handler
            // 
            this.error_handler.AutoSize = true;
            this.error_handler.Location = new System.Drawing.Point(195, 364);
            this.error_handler.Name = "error_handler";
            this.error_handler.Size = new System.Drawing.Size(271, 13);
            this.error_handler.TabIndex = 10;
            this.error_handler.Text = "YOU CAN NOT INSERT MORE THAN A CHARACTER";
            // 
            // n_lives
            // 
            this.n_lives.AutoSize = true;
            this.n_lives.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_lives.Location = new System.Drawing.Point(136, 342);
            this.n_lives.Name = "n_lives";
            this.n_lives.Size = new System.Drawing.Size(0, 16);
            this.n_lives.TabIndex = 11;
            // 
            // guess_word
            // 
            this.guess_word.Location = new System.Drawing.Point(146, 472);
            this.guess_word.Name = "guess_word";
            this.guess_word.Size = new System.Drawing.Size(384, 20);
            this.guess_word.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "PRESS HERE IF YOU WANT TO GUESS THE WHOLE WORD";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(203, 533);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 58);
            this.button5.TabIndex = 14;
            this.button5.Text = "Guess";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(710, 623);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guess_word);
            this.Controls.Add(this.n_lives);
            this.Controls.Add(this.error_handler);
            this.Controls.Add(this.final_word);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.argument);
            this.Controls.Add(this.word);
            this.Controls.Add(this.letter_chosen);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox letter_chosen;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label argument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label final_word;
        private System.Windows.Forms.Label error_handler;
        private System.Windows.Forms.Label n_lives;
        private System.Windows.Forms.TextBox guess_word;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
    }
}

