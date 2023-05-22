//using log.Model;
using logReaderMaster.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace logReaderMaster.DAL
{
    public class RegistryDAL
    {
        /*private string _connectionStringRegistry;
        public RegistryDAL(IConfiguration iconfiguration)
        {
            _connectionStringRegistry = iconfiguration.GetConnectionString("Registry");
        }

        public bool WriteToRegistry(string payload, int response)
        {
            using (SqlConnection con = new SqlConnection(_connectionStringRegistry))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tb_db1slave_registry (id, Slave_identity_country_zone, Timestamp, Status) VALUES ('1', 'sample_se_az1', '12:00:00', '" + payload + "')", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                Console.WriteLine("Connection Established to the Registry database!");
                
                
                Console.WriteLine(cmd.ExecuteNonQuery());
                con.Close();
                return true;


                //if (cmd.ExecuteReader() != null)
                //  {
                //    con.Close();
                //    return true;
                //}else
                //{
                //    con.Close();
                //    return false;
                //};

            }
        }*/
    }
}


