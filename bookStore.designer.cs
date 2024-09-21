namespace SamyBookStore
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
            label7 = new Label();
            cbBooks = new ComboBox();
            txtSubtotal = new TextBox();
            txtTotal = new TextBox();
            txtTendered = new TextBox();
            txtChange = new TextBox();
            brnReset = new Button();
            nudQTY = new NumericUpDown();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnAdd = new Button();
            btnRemove = new Button();
            nudTax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudQTY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTax).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 463);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Subtotal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 495);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Tax (%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 530);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 564);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Tendered";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 602);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 6;
            label7.Text = "Change Due";
            // 
            // cbBooks
            // 
            cbBooks.FormattingEnabled = true;
            cbBooks.Items.AddRange(new object[] { "Harry Potter ($199.00)", "Intro to C# ($60.00)", "Programming for Dummies ($150.00)" });
            cbBooks.Location = new Point(113, 42);
            cbBooks.Name = "cbBooks";
            cbBooks.Size = new Size(301, 23);
            cbBooks.TabIndex = 9;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(278, 460);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(136, 23);
            txtSubtotal.TabIndex = 10;
            txtSubtotal.Text = "$0.00";
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(278, 527);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(136, 23);
            txtTotal.TabIndex = 11;
            txtTotal.Text = "$0.00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTendered
            // 
            txtTendered.Location = new Point(278, 561);
            txtTendered.Name = "txtTendered";
            txtTendered.Size = new Size(136, 23);
            txtTendered.TabIndex = 12;
            txtTendered.Text = "$0.00";
            txtTendered.TextAlign = HorizontalAlignment.Right;
            txtTendered.TextChanged += txtTendered_TextChanged;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(278, 599);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(136, 23);
            txtChange.TabIndex = 13;
            txtChange.Text = "$0.00";
            txtChange.TextAlign = HorizontalAlignment.Right;
            // 
            // brnReset
            // 
            brnReset.Location = new Point(339, 138);
            brnReset.Name = "brnReset";
            brnReset.Size = new Size(75, 35);
            brnReset.TabIndex = 17;
            brnReset.Text = "Reset";
            brnReset.UseVisualStyleBackColor = true;
            brnReset.Click += brnReset_Click;
            // 
            // nudQTY
            // 
            nudQTY.Location = new Point(113, 84);
            nudQTY.Name = "nudQTY";
            nudQTY.Size = new Size(120, 23);
            nudQTY.TabIndex = 18;
            nudQTY.TextAlign = HorizontalAlignment.Right;
            nudQTY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(38, 199);
            listView1.Name = "listView1";
            listView1.Size = new Size(376, 240);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "Book Name";
            columnHeader1.Text = "Book Name";
            columnHeader1.Width = 203;
            // 
            // columnHeader2
            // 
            columnHeader2.Tag = "Quantity";
            columnHeader2.Text = "Quantity";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            columnHeader3.Tag = "Price";
            columnHeader3.Text = "Price";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 85;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(177, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(258, 138);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 35);
            btnRemove.TabIndex = 21;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // nudTax
            // 
            nudTax.DecimalPlaces = 2;
            nudTax.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            nudTax.Location = new Point(278, 498);
            nudTax.Name = "nudTax";
            nudTax.Size = new Size(136, 23);
            nudTax.TabIndex = 22;
            nudTax.TextAlign = HorizontalAlignment.Right;
            nudTax.Value = new decimal(new int[] { 625, 0, 0, 131072 });
            nudTax.ValueChanged += nudTax_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 645);
            Controls.Add(nudTax);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Controls.Add(nudQTY);
            Controls.Add(brnReset);
            Controls.Add(txtChange);
            Controls.Add(txtTendered);
            Controls.Add(txtTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(cbBooks);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Store Management";
            ((System.ComponentModel.ISupportInitialize)nudQTY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTax).EndInit();
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
        private Label label7;
        private DomainUpDown domainUpDown1;
        private ComboBox cbBooks;
        private TextBox txtSubtotal;
        private TextBox txtTotal;
        private TextBox txtTendered;
        private TextBox txtChange;
        private Button brnReset;
        private NumericUpDown nudQTY;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAdd;
        private Button btnRemove;
        private NumericUpDown nudTax;
    }
}
