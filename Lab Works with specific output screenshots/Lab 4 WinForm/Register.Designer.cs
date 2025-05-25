namespace Inheritance_Form
{
    partial class Register
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
            checkedListBox1 = new CheckedListBox();
            label7 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button4 = new Button();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Province = new DataGridViewTextBoxColumn();
            District = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Java", "JavaScript" });
            checkedListBox1.Location = new Point(178, 168);
            checkedListBox1.Margin = new Padding(2, 1, 2, 1);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.RightToLeft = RightToLeft.No;
            checkedListBox1.Size = new Size(131, 22);
            checkedListBox1.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 176);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(31, 15);
            label7.TabIndex = 72;
            label7.Text = "Skill:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(178, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(82, 15);
            label2.TabIndex = 62;
            label2.Text = "Sign Up Form";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bhaktapur", "Kathmandu", "Lalitpur", "Ilam ", "Bara", "Jhapa", "Mustang", "Makwanpur", "Chitwan", "Baglung" });
            comboBox2.Location = new Point(178, 135);
            comboBox2.Margin = new Padding(2, 1, 2, 1);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.No;
            comboBox2.Size = new Size(132, 23);
            comboBox2.TabIndex = 71;
            // 
            // button4
            // 
            button4.Location = new Point(178, 229);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(81, 22);
            button4.TabIndex = 67;
            button4.Text = "Register";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(42, 15);
            label3.TabIndex = 63;
            label3.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 137);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(47, 15);
            label6.TabIndex = 66;
            label6.Text = "District:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bagmati", "Gandaki", "Lumbini", "Madhesh", "Koshi", "Karnali", "Sudurpaschim" });
            comboBox1.Location = new Point(178, 105);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 70;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 45);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(31, 15);
            label4.TabIndex = 64;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 105);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(56, 15);
            label5.TabIndex = 65;
            label5.Text = "Province:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(178, 75);
            numericUpDown1.Margin = new Padding(2, 1, 2, 1);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = RightToLeft.No;
            numericUpDown1.Size = new Size(48, 23);
            numericUpDown1.TabIndex = 69;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Age, Province, District });
            dataGridView1.Location = new Point(284, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(428, 150);
            dataGridView1.TabIndex = 74;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            // 
            // Province
            // 
            Province.HeaderText = "Province";
            Province.Name = "Province";
            // 
            // District
            // 
            District.HeaderText = "District";
            District.Name = "District";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 431);
            Controls.Add(dataGridView1);
            Controls.Add(checkedListBox1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label7;
        private Label label2;
        private ComboBox comboBox2;
        private Button button4;
        private Label label3;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn District;
    }
}