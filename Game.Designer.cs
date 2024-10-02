namespace Math_Game
{
    partial class Game
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
            label1 = new Label();
            label2 = new Label();
            lblFirst = new Label();
            lblOperation = new Label();
            lblSecond = new Label();
            label6 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            txtInput = new TextBox();
            lblCorrectIncorrect = new Label();
            lblCorrect = new Label();
            lblIncorrect = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 27);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Correct:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 27);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Incorect:";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(66, 130);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(38, 15);
            lblFirst.TabIndex = 2;
            lblFirst.Text = "label3";
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Location = new Point(110, 130);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(38, 15);
            lblOperation.TabIndex = 3;
            lblOperation.Text = "label4";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(167, 130);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(38, 15);
            lblSecond.TabIndex = 4;
            lblSecond.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 130);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 5;
            label6.Text = "??";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(420, 114);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(420, 161);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(22, 216);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(429, 23);
            txtInput.TabIndex = 8;
            txtInput.KeyDown += txtInput_KeyDown;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // lblCorrectIncorrect
            // 
            lblCorrectIncorrect.AutoSize = true;
            lblCorrectIncorrect.Location = new Point(27, 263);
            lblCorrectIncorrect.Name = "lblCorrectIncorrect";
            lblCorrectIncorrect.Size = new Size(0, 15);
            lblCorrectIncorrect.TabIndex = 9;
            // 
            // lblCorrect
            // 
            lblCorrect.AutoSize = true;
            lblCorrect.Location = new Point(110, 27);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(13, 15);
            lblCorrect.TabIndex = 10;
            lblCorrect.Text = "0";
            // 
            // lblIncorrect
            // 
            lblIncorrect.AutoSize = true;
            lblIncorrect.Location = new Point(466, 27);
            lblIncorrect.Name = "lblIncorrect";
            lblIncorrect.Size = new Size(13, 15);
            lblIncorrect.TabIndex = 11;
            lblIncorrect.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 130);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 12;
            label3.Text = "=";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 295);
            Controls.Add(label3);
            Controls.Add(lblIncorrect);
            Controls.Add(lblCorrect);
            Controls.Add(lblCorrectIncorrect);
            Controls.Add(txtInput);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label6);
            Controls.Add(lblSecond);
            Controls.Add(lblOperation);
            Controls.Add(lblFirst);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFirst;
        private Label lblOperation;
        private Label lblSecond;
        private Label label6;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txtInput;
        private Label lblCorrectIncorrect;
        private Label lblCorrect;
        private Label lblIncorrect;
        private Label label3;
    }
}
