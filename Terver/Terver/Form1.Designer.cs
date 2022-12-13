namespace Terver
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.Label();
            this.Combination = new System.Windows.Forms.CheckBox();
            this.Accommodation = new System.Windows.Forms.CheckBox();
            this.Permutation = new System.Windows.Forms.CheckBox();
            this.Answer = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.TextBox();
            this.InputK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перестановка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сочетание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Размещение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Operations
            // 
            this.Operations.AutoSize = true;
            this.Operations.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Operations.Location = new System.Drawing.Point(182, 37);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(380, 50);
            this.Operations.TabIndex = 3;
            this.Operations.Text = "Выберите Операцию";
            // 
            // Combination
            // 
            this.Combination.AutoSize = true;
            this.Combination.Location = new System.Drawing.Point(332, 349);
            this.Combination.Name = "Combination";
            this.Combination.Size = new System.Drawing.Size(117, 24);
            this.Combination.TabIndex = 4;
            this.Combination.Text = "Повторение";
            this.Combination.UseVisualStyleBackColor = true;
            // 
            // Accommodation
            // 
            this.Accommodation.AutoSize = true;
            this.Accommodation.Location = new System.Drawing.Point(604, 349);
            this.Accommodation.Name = "Accommodation";
            this.Accommodation.Size = new System.Drawing.Size(117, 24);
            this.Accommodation.TabIndex = 5;
            this.Accommodation.Text = "Повторение";
            this.Accommodation.UseVisualStyleBackColor = true;
            // 
            // Permutation
            // 
            this.Permutation.AutoSize = true;
            this.Permutation.Location = new System.Drawing.Point(73, 349);
            this.Permutation.Name = "Permutation";
            this.Permutation.Size = new System.Drawing.Size(117, 24);
            this.Permutation.TabIndex = 6;
            this.Permutation.Text = "Повторение";
            this.Permutation.UseVisualStyleBackColor = true;
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(285, 225);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(48, 20);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "Ответ";
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(194, 130);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(139, 27);
            this.InputN.TabIndex = 8;
            // 
            // InputK
            // 
            this.InputK.Location = new System.Drawing.Point(423, 130);
            this.InputK.Name = "InputK";
            this.InputK.Size = new System.Drawing.Size(139, 27);
            this.InputK.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "k";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputK);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Permutation);
            this.Controls.Add(this.Accommodation);
            this.Controls.Add(this.Combination);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label Operations;
        private CheckBox Combination;
        private CheckBox Accommodation;
        private CheckBox Permutation;
        private Label Answer;
        private TextBox InputN;
        private TextBox InputK;
        private Label label2;
        private Label label3;
    }
}