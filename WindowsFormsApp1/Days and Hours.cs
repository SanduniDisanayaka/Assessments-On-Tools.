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
    public partial class Form2 : Form
    {
        SqlConnection con = null;


        private object txtNo_Of_Working_Days;
        private object txtLec_ID;
        private readonly object addWorkingDaysAndHoursTableAdapter;

        public object txtlocation { get; private set; }

        public Form2()
        {
            InitializeComponent();
          
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
            
        {   //Create Your Connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
           
            {
                try
                {
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into Add_working_Days_And_Hours(Lec_ID,No_Of_Working_Days,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,Working_Time_Per_Day,StartingTime_Hours,StartingTime_Min,EndingTime_Hours,EndingTime_Min) values('" + textBox1.Text.ToString() + "','" + Convert.ToInt32(numericUpDown1.Text) + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "','" + checkBox3.Checked + "','" + checkBox4.Checked + "','" + checkBox5.Checked + "','" + checkBox6.Checked + "','" + checkBox7.Checked + "','" + Convert.ToInt32(numericUpDown2.Text) + "','" + Convert.ToInt32(numericUpDown3.Text) + "','" + Convert.ToInt32(numericUpDown5.Text) + "','" + Convert.ToInt32(numericUpDown4.Text) + "','" + Convert.ToInt32(numericUpDown6.Text) + "')", con);                       
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successful Inserted.");
                        con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error"+ex);
                }
                loadTable();


            }
            void BindData()
            {

                SqlCommand cmd = new SqlCommand("Select * Add_working_Days_And_Hours", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;


            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //Create Your Connection
            con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
           
            loadTable();
        }

        private void loadTable()
        {
            try
            {
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        
        private void BindData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Add_working_Days_And_Hours";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

       
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   //Create Your Connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("update Add_working_Days_And_Hours set No_Of_Working_Days='" + Convert.ToInt32(numericUpDown1.Text) +"',  Monday='" + checkBox1.Checked + "', Tuesday='" + checkBox2.Checked + "',Wednesday='" + checkBox3.Checked + "',Thursday='" + checkBox4.Checked + "',Friday='" + checkBox5.Checked + "',Saturday='" + checkBox6.Checked + "',Sunday='" + checkBox7.Checked + "',Working_Time_Per_Day='" + Convert.ToInt32(numericUpDown2.Text) + "',StartingTime_Hours='" + Convert.ToInt32(numericUpDown3.Text) + "',StartingTime_Min='" + Convert.ToInt32(numericUpDown5.Text) + "',EndingTime_Hours='" + Convert.ToInt32(numericUpDown4.Text) + "',EndingTime_Min='" + Convert.ToInt32(numericUpDown6.Text) + "'where Lec_ID='" + textBox1.Text.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successful Updated.");
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                loadTable();
              

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Create Your Connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Select * from Add_working_Days_And_Hours", con);
                    command.ExecuteNonQuery();
                    con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
                loadTable();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   //Create Your Connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            {
                try
                { 
                    
                    search();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
               

            }
        }
        
        private void search()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Add_working_Days_And_Hours Where Lec_ID= '" + Search.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {   //Create Your Connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");


            if (Search.Text != "")
            {
                if (MessageBox.Show("Are You Sure Want to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open(); 
                    SqlCommand command = new SqlCommand("Delete from Add_working_Days_And_Hours  Where Lec_ID= '" + Search.Text.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfuly Deleted");
                    BindData();
                }
            }

            else
            {
                MessageBox.Show("Please Enter Lec ID!");
            }





        }
    }
}
