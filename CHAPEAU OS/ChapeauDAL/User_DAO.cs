using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
namespace ChapeauDAL
{
    public class User_DAO:Base
    {
        public User GetUserByUserName(string username, string jobtype)//removed password as it is not usefull in identifying the user
        {
            OpenConnection();
            // removed " and userpassword=@userpassword" at end of query as username is enough to get a user
            SqlCommand command = new SqlCommand("select S.Employee_Id, S.Name , S.Salary, S.Username, S.Password from "+jobtype+" J join Staff S on j.id = s.Employee_id where Username like @username", OpenConnection());
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();
            User oneUser = new User();
            if (reader.Read())
            {
                oneUser = ReadUser(reader);
            }
            reader.Close();
            CloseConnection();
            return oneUser;
        }

        private User ReadUser(SqlDataReader reader)
        {
            try
            {
                User OneUser = new User()
                {
                    ID = (int)reader["employee_id"],
                    Name = (string)reader["Name"],
                    Salary = (decimal)reader["Salary"],
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"],

                };
                return OneUser;
            }
            catch (Exception e)
            {
                throw new Exception("Error : " + e);//added exception code
            }
        }
    }
}
