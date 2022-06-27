using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class ProductDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductDAL()
        {
            con =  new SqlConnection(Startup.ConnectionString);
        }

        public List<Product> GetAllProduct()
        {
            List<Product> list = new List<Product>();

            string str = "select * from Product";
            cmd = new SqlCommand(str, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Product p = new Product();
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

        public Product GetProductById(int id)
        {
            Product p = new Product();
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

        public int Save(Product prod)
        {
            string str = "insert into Product values(@name,@price)";
            cmd = new SqlCommand(str, con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price",prod.Price);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

            
        }

        public int Update(Product prod)
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
