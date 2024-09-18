namespace Quiz1
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dpSex = new ComboBox();
            label3 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rbPacific = new RadioButton();
            rbAsian = new RadioButton();
            rbLatino = new RadioButton();
            rbAmerican = new RadioButton();
            rbBlack = new RadioButton();
            rbWhite = new RadioButton();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            cbHumble = new CheckBox();
            cbResponsible = new CheckBox();
            cbHardWorking = new CheckBox();
            cbCompassionate = new CheckBox();
            cbHonest = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 40);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(293, 23);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 71);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(293, 23);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // dpSex
            // 
            dpSex.FormattingEnabled = true;
            dpSex.Items.AddRange(new object[] { "Male", "Female" });
            dpSex.Location = new Point(103, 105);
            dpSex.Name = "dpSex";
            dpSex.Size = new Size(293, 23);
            dpSex.TabIndex = 4;
            dpSex.SelectedIndexChanged += dpSex_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 109);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Sex/Gender";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(460, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(460, 71);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(114, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(460, 105);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPacific);
            groupBox1.Controls.Add(rbAsian);
            groupBox1.Controls.Add(rbLatino);
            groupBox1.Controls.Add(rbAmerican);
            groupBox1.Controls.Add(rbBlack);
            groupBox1.Controls.Add(rbWhite);
            groupBox1.Location = new Point(23, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 185);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Race and Ethnicity";
            // 
            // rbPacific
            // 
            rbPacific.AutoSize = true;
            rbPacific.Location = new Point(19, 145);
            rbPacific.Name = "rbPacific";
            rbPacific.Size = new Size(170, 19);
            rbPacific.TabIndex = 5;
            rbPacific.Text = "Pacific Islander or Hawaiian";
            rbPacific.UseVisualStyleBackColor = true;
            // 
            // rbAsian
            // 
            rbAsian.AutoSize = true;
            rbAsian.Location = new Point(19, 120);
            rbAsian.Name = "rbAsian";
            rbAsian.Size = new Size(54, 19);
            rbAsian.TabIndex = 4;
            rbAsian.Text = "Asian";
            rbAsian.UseVisualStyleBackColor = true;
            // 
            // rbLatino
            // 
            rbLatino.AutoSize = true;
            rbLatino.Location = new Point(19, 95);
            rbLatino.Name = "rbLatino";
            rbLatino.Size = new Size(121, 19);
            rbLatino.TabIndex = 3;
            rbLatino.Text = "Latino or Hispanic";
            rbLatino.UseVisualStyleBackColor = true;
            // 
            // rbAmerican
            // 
            rbAmerican.AutoSize = true;
            rbAmerican.Location = new Point(19, 70);
            rbAmerican.Name = "rbAmerican";
            rbAmerican.Size = new Size(200, 19);
            rbAmerican.TabIndex = 2;
            rbAmerican.Text = "American Indian or Alaska Native";
            rbAmerican.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Location = new Point(19, 45);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(162, 19);
            rbBlack.TabIndex = 1;
            rbBlack.Text = "Black or African American";
            rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            rbWhite.AutoSize = true;
            rbWhite.Checked = true;
            rbWhite.Location = new Point(19, 20);
            rbWhite.Name = "rbWhite";
            rbWhite.Size = new Size(127, 19);
            rbWhite.TabIndex = 0;
            rbWhite.TabStop = true;
            rbWhite.Text = "White or Caucasian";
            rbWhite.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 365);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(551, 160);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbHumble);
            groupBox2.Controls.Add(cbResponsible);
            groupBox2.Controls.Add(cbHardWorking);
            groupBox2.Controls.Add(cbCompassionate);
            groupBox2.Controls.Add(cbHonest);
            groupBox2.Location = new Point(423, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(151, 185);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Character Traits";
            // 
            // cbHumble
            // 
            cbHumble.AutoSize = true;
            cbHumble.Location = new Point(13, 121);
            cbHumble.Name = "cbHumble";
            cbHumble.Size = new Size(69, 19);
            cbHumble.TabIndex = 4;
            cbHumble.Text = "Humble";
            cbHumble.UseVisualStyleBackColor = true;
            // 
            // cbResponsible
            // 
            cbResponsible.AutoSize = true;
            cbResponsible.Location = new Point(13, 96);
            cbResponsible.Name = "cbResponsible";
            cbResponsible.Size = new Size(89, 19);
            cbResponsible.TabIndex = 3;
            cbResponsible.Text = "Responsible";
            cbResponsible.UseVisualStyleBackColor = true;
            // 
            // cbHardWorking
            // 
            cbHardWorking.AutoSize = true;
            cbHardWorking.Location = new Point(13, 71);
            cbHardWorking.Name = "cbHardWorking";
            cbHardWorking.Size = new Size(100, 19);
            cbHardWorking.TabIndex = 2;
            cbHardWorking.Text = "Hard-working";
            cbHardWorking.UseVisualStyleBackColor = true;
            // 
            // cbCompassionate
            // 
            cbCompassionate.AutoSize = true;
            cbCompassionate.Location = new Point(13, 45);
            cbCompassionate.Name = "cbCompassionate";
            cbCompassionate.Size = new Size(108, 19);
            cbCompassionate.TabIndex = 1;
            cbCompassionate.Text = "Compassionate";
            cbCompassionate.UseVisualStyleBackColor = true;
            // 
            // cbHonest
            // 
            cbHonest.AutoSize = true;
            cbHonest.Location = new Point(13, 20);
            cbHonest.Name = "cbHonest";
            cbHonest.Size = new Size(64, 19);
            cbHonest.TabIndex = 0;
            cbHonest.Text = "Honest";
            cbHonest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 551);
            Controls.Add(groupBox2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(dpSex);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private ComboBox dpSex;
        private Label label3;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnReset;
        private GroupBox groupBox1;
        private ListView listView1;
        private GroupBox groupBox2;
        private RadioButton rbPacific;
        private RadioButton rbAsian;
        private RadioButton rbLatino;
        private RadioButton rbAmerican;
        private RadioButton rbBlack;
        private RadioButton rbWhite;
        private CheckBox cbHumble;
        private CheckBox cbResponsible;
        private CheckBox cbHardWorking;
        private CheckBox cbCompassionate;
        private CheckBox cbHonest;
    }
}
