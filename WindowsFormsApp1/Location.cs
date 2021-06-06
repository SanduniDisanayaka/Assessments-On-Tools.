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
    public partial class Location : Form
    {
        SqlConnection con = null;
        public Location()
        {
            InitializeComponent();

            //Create your connection
            con = new SqlConnection("Data Source=DESKTOP-33MU7I7\\MYMSSQLSERVER;Initial Catalog=Time_Table_Management_System;Integrated Security=True;");
        }

        private void Location_Load(object sender, EventArgs e)
        {
           
            loadTable();
        }

        private void loadTable()
        {
            try
            {

                con.Open();
              

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Location";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-33MU7I7\\MYMSSQLSERVER;Initial Catalog=Time_Table_Management_System;Integrated Security=True");

            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("insert into Location(Location_ID,Location,Starting_time,Ending_time,Day) values('" + textBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + Convert.ToInt32(numericUpDown1.Text) + "','" + Convert.ToInt32(numericUpDown2.Text) + "','"+ dateTimePicker1.Text.ToString()   + "')", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successful Inserted.");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                loadTable();


            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-33MU7I7\\MYMSSQLSERVER;Initial Catalog=Time_Table_Management_System;Integrated Security=True");

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
            cmd.CommandText = "select * from Location Where Location_ID= '" + textBox7.Text.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-33MU7I7\\MYMSSQLSERVER;Initial Catalog=Time_Table_Management_System;Integrated Security=True");


            if (textBox7.Text != "")
            {
                if (MessageBox.Show("Are You Sure Want to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    con.Open();
                    SqlCommand command = new SqlCommand("Delete from  Location Where Location_ID= '" + textBox7.Text.ToString() + "'", con);
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

        private void button3_Click(object sender, EventArgs e)
        {   //Create your connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-33MU7I7\\MYMSSQLSERVER;Initial Catalog=Time_Table_Management_System;Integrated Security=True");

            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Select * from Location", con);
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
    }
}
