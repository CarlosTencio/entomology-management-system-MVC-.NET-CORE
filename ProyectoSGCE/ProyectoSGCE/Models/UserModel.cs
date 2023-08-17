using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProyectoSGCE.Models
{
    public class UserModel
    {
        private IConfiguration Configuration { get; }

        public UserModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public UserModel()
        {
        }
        

             public bool UsernameExists(User user)
             {
                 string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                 using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "sp_search_user";
                     using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                         command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@nombre_usuario", user.Username);
    
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                             bool exists = reader.HasRows;

                                return exists;
                            }
                     }
                 }
             }

        public int IsUsernameAlreadyExists(User user)
        {
            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "sp_verify_login";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre_usuario", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    var param = command.Parameters.Add("@Result", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output; // Add the output parameter

                    connection.Open();
                    command.ExecuteNonQuery(); // Execute the stored procedure

                    if (param.Value != DBNull.Value)
                    {
                        int exists = (int)param.Value; // Get the value of the output parameter
                        return exists;
                    }
                    else
                    {
                        // Handle the case when the output parameter is DBNull.Value
                        return -1; // or any other suitable value indicating the null result
                    }
                }
            }
        }


        public bool RegisterUser(User user)
        {
            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "sp_register_user";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre_usuario", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);

                    connection.Open();
                    bool usernameExists = UsernameExists(user);
                    if (usernameExists)
                    {
                       return false;
                    }

                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
        }

        public void RecordComment(CommentSpecimen comment)
        {
            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "sp_register_comment_user";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name_user", comment.User); // Asignar el valor del nombre de usuario al parámetro @name_user
                command.Parameters.AddWithValue("@Comment", comment.Comment);
                command.Parameters.AddWithValue("@id_specimen", comment.Id_specimen);


                command.ExecuteNonQuery();
                 connection.Close();
            }
           
        }


        public async Task<List<CommentSpecimen>> GetComments(int specimen)
        {
            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            List<CommentSpecimen> results = new List<CommentSpecimen>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_getcomments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_specimen", specimen);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentSpecimen commentSpecimen = new CommentSpecimen();
                            commentSpecimen.User = reader.GetString(0);
                            commentSpecimen.Comment = reader.GetString(1);
                            commentSpecimen.Id_specimen = reader.GetInt32(2);

                            results.Add(commentSpecimen);
                        }
                    }
                }
                connection.Close();
            }
            
            return results;
        }

    }
}
