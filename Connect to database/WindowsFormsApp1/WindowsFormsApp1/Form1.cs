using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
       
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // @id, @name,@salary are the variable names
                string str = "insert into Emp values(@name,@salary)";
                cmd = new SqlCommand(str, con);
               // cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                // open DB connection
                con.Open();
                // fire the query insert / update / delete
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // @id, @name,@salary are the variable names
                string str = "update Emp set Name=@name, Salary=@salary where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                // open DB connection
                con.Open();
                // fire the query insert / update / delete
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // @id, @name,@salary are the variable names
                string str = "delete from Emp where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                
                // open DB connection
                con.Open();
                // fire the query insert / update / delete
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Delete");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Emp where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                // open DB connection
                con.Open();
                // fire the query select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)// check that record is present in dr object or not
                {
                    while (dr.Read()) // read data from dr object
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtSalary.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnshowdata_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Emp";
                cmd = new SqlCommand(str, con);
                
                // open DB connection
                con.Open();
                // fire the query select
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}


