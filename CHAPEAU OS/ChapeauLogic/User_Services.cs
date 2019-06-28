using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class User_Services
    {
        User_DAO User_DAO = new User_DAO();

        public User GetUserByUserName(string username,string jobtype)
        {
            try
            {
                User user = User_DAO.GetUserByUserName(username, jobtype);
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(" " + e.Message);
            }

        }
    }
}
