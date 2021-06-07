using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Session : Form
    {
        private object con;

        public Session()
        {
            InitializeComponent();

            //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            {
                try
                {
                con.Open();
                SqlCommand command = new SqlCommand("insert into Session(Lec_ID,Lec_Name,[Group],Sub_Group,Session_ID,Time) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + Convert.ToInt32(textBox3.Text) + "','" + Convert.ToInt32(textBox4.Text) + "','" + Convert.ToInt32(textBox5.Text) + "','" + Convert.ToInt32(numericUpDown1.Text) + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successful Inserted.");
                con.Close();
                }
                catch (Exception ex)
                {
                     MessageBox.Show("Error");
                 }
                loadTable();


            }
        }

        private void loadTable()
        {   //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Session";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        //test
        private void button2_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            //.
            {
                try
                {
                con.Open();
                SqlCommand command = new SqlCommand("update  Session set  Lec_Name='" + textBox2.Text.ToString() + "',[Group]='" + Convert.ToInt32(textBox4.Text) + "',Sub_Group='" + Convert.ToInt32(textBox5.Text) + "',Session_ID='" + Convert.ToInt32(textBox5.Text) + "',Time='" + Convert.ToInt32(numericUpDown1.Text) + "'where Lec_ID='" + textBox1.Text.ToString() + "'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Successful Updated.");
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
        {   //Create your connection
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
        {   //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Session Where Lec_ID= '" + textBox7.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");

            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Select * from Session", con);
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

        private void button5_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Server = tcp:sqlserverml12345.database.windows.net,1433; Initial Catalog = Time_Table_Management_System; Persist Security Info = False; User ID = Millennium; Password = Malinda@12345; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");


            if (textBox7.Text != "")
            {
                if (MessageBox.Show("Are You Sure Want to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete from Session  Where Lec_ID= '" + textBox7.Text.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfuly Deleted");
                    loadTable();
                }
            }

            else
            {
                MessageBox.Show("Please Enter Lec ID!");
            }
        }

        private void Session_Load(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
