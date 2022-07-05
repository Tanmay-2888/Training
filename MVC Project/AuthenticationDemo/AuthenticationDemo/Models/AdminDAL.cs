using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AuthenticationDemo.Models
{
    public class AdminDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public AdminDAL()
        {
            con = new SqlConnection(Startup.ConnectionString);
        }

        public List<Admin> GetAllProduct()
        {
            List<Admin> list = new List<Admin>();

            string str = "select * from Product";
            cmd = new SqlCommand(str, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Admin p = new Admin();
                    p.Id = Convert.ToInt32(dr["Id"]);
                    p.Name = dr["Name"].ToString();
                    p.Price = (int)Convert.ToDecimal(dr["Price"]);
                    list.Add(p);

                }
                con.Close();
                return list;
            }
            else
            {
                con.Close();
                return list;

            }


        }

        public Admin GetProductById(int id)
        {
            Admin p = new Admin();
            string query = "select * from Product where id=@id";
            cmd = new SqlCommand(@query, con);
            cmd.Parameters.AddWithValue("id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    p.Id = Convert.ToInt32(dr["Id"]);
                    p.Name = dr["Name"].ToString();
                    p.Price = Convert.ToSingle(dr["Price"]);


                }
                con.Close();
                return p;
            }

            con.Close();
            return p;
        }

        public int Save(Admin prod)
        {
            string str = "insert into Product values(@name,@price)";
            cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;


        }

        public int Update(Admin prod)
        {
            string str = "update Product set Name=@name,Price=@price where Id=@id";
            cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }

        public int Delete(int id)
        {
            string str = "delete from Product where Id=@id";
            cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;


        }

    }
}

