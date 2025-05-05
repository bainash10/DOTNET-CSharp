using System;
using System.Windows.Forms;

namespace Inheritance_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            LoadFormIntoPanel(loginPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register registerPage = new Register();
            LoadFormIntoPanel(registerPage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator calculatorPage = new Calculator();
            LoadFormIntoPanel(calculatorPage);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label3.Visible = true;
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
