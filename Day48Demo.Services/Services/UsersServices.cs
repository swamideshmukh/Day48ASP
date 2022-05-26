
using Day48Demo.Services.Models;
using Day48Demo.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Day48Demo.Services.Services
{
    public class UsersServices
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["UserManagement"].ConnectionString;

        public List<Users> GetAll()
        {
            var users = new List<Users>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Users_GetAll";
                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new Users
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = reader["LastName"].GetData<string>(),
                                DateOfBirth =reader["DateOfBirth"].GetData<DateTime>(),
                                Pan = reader["Pan"].GetData<string>(),
                                Address=reader["Address"].GetData<string>(),
                                Gender=reader["Gender"].GetData<string>(),
                                MobileNumber = reader["MobileNumber"].GetData<string>(),
                                Email = reader["Email"].GetData<string>(),
                                Comments =  reader["Comments"].GetData<string>(),
                                DepartmentRefId=(int)reader["DepartmentRefId"]



                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }



        public void Add(Users users)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Users_Add";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", users.FirstName);
                    command.Parameters.AddWithValue("@LastName", users.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", users.DateOfBirth);
                    command.Parameters.AddWithValue("@Pan", users.Pan);
                    command.Parameters.AddWithValue("@Address", users.Address);
                    command.Parameters.AddWithValue("@Gender", users.Gender);
                    command.Parameters.AddWithValue("@MobileNumber", users.MobileNumber);
                    command.Parameters.AddWithValue("@Email", users.Email);
                    command.Parameters.AddWithValue("@Comments", users.Comments);
                    command.Parameters.AddWithValue("@DepartmentRefId", users.DepartmentRefId);

                    connection.Open();
                    var rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }
    
       public void Update(Users users)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Users_Update";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", users.Id);
                    command.Parameters.AddWithValue("@FirstName", users.FirstName);
                    command.Parameters.AddWithValue("@LastName", users.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", users.DateOfBirth);
                    command.Parameters.AddWithValue("@Pan", users.Pan);
                    command.Parameters.AddWithValue("@Adress", users.Address);
                    command.Parameters.AddWithValue("@Gender", users.Gender);
                    command.Parameters.AddWithValue("@MobileNumber", users.MobileNumber);
                    command.Parameters.AddWithValue("@Email", users.Email);
                    command.Parameters.AddWithValue("@Comments", users.Comments);
                    command.Parameters.AddWithValue("@DepartmentRefId", users.DepartmentRefId);

                    connection.Open();
                    var rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }

        public void Delete(Users users)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Users_Delete";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", users.Id);
                   
                    connection.Open();
                    var rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }


        public Users GetById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "Users_GetById";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var user = new Users
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                DateOfBirth = (DateTime)reader["DateOfBirth"],
                                Pan = (string)reader["Pan"],
                                Address = (string)reader["Address"],
                                Gender = (string)reader["Gender"],
                                MobileNumber = (string)reader["MobileNumber"],
                                Email = (string)reader["Email"],
                                Comments = (string)reader["Comments"],
                                DepartmentRefId = (int)reader["DepartmentRefId"]



                            };
                            return user;
                        }
                    }
                }
            }

            return null;
        }
    }
}