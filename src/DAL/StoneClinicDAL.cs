using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using StoneClinic.Models.DB;
using Microsoft.Extensions.Configuration;


namespace StoneClinic.DAL
{
    public class StoneClinicDAL
    {
        public string cnn = "";
        public StoneClinicDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                            (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }
        public int UsrLogin(Usr obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("UsrLogin", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", obj.UserName);
            cmd.Parameters.AddWithValue("@pwrd", obj.Password);
            con.Open();
            IDataReader read = cmd.ExecuteReader();
            if (read.Read())
                return (1);
            con.Close();
            return (0);
        }
    }
}
