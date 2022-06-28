using System.Data.SqlClient;

namespace WebApplication2.Models
{
    public class UserDAL
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public UserDAL()
        {
            con = new SqlConnection(Startup.ConnectionString);
            

        }
        public int Save(User u)
        {
            string query = "insert into User values(@name,@EmailId,@Password)";
            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

        }


    }
}
