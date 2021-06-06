using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        SqlConnection con = null;

        





        public Form1()
        {
            InitializeComponent();
            //con = new SqlConnection("Data Source=DESKTOP-DBRN4US;Initial Catalog=Time_Table_Management_System;Integrated Security=True;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();

            

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton17_Click(object sender, EventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {

        }

        private void iconButton18_Click(object sender, EventArgs e)
        {

        }

        private void iconButton13_Click(object sender, EventArgs e)
        {

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {

        }

        private void iconButton15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Viewpanel2.Controls.Add(childForm);
            Viewpanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            label1.Text = "Home";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //openChildForm(new Lecturer());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           // openChildForm(new Subject());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            openChildForm(new Session());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //openChildForm(new Student_Group());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            //openChildForm(new Tags());
            
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new Location());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            //openChildForm(new Generate_Time_Table());
        }

        private void iconButton15_Click_1(object sender, EventArgs e)
        {
           // openChildForm(new Location());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton17_Click_1(object sender, EventArgs e)
        {
           // openChildForm(new Session());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void iconButton11_Click_1(object sender, EventArgs e)
        {
          //  openChildForm(new Lecturer());
        }

        private void iconButton12_Click_1(object sender, EventArgs e)
        {
          //  openChildForm(new Subject());
        }

        private void iconButton13_Click_1(object sender, EventArgs e)
        {
           // openChildForm(new Student_Group());
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
           // openChildForm(new Tags());
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            
        }
    }
}
