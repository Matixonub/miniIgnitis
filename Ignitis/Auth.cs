using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis
{
    internal class Auth
    {
        //, category_name where category_id = category_id and user.category_id=
        static public string category_id, user_id, group_id, utility_id;

        static public void Authorization(string login, string password)
        {
            try {
                DataBase.msCommand.CommandText = @"select category_id, id from user where username = '" + login + "' and password = '" + password + "'";
                Object result = DataBase.msCommand.ExecuteScalar();
                if (result != null)
                    category_id = result.ToString();
                else
                    category_id = null;
            }
            catch 
            {
                category_id = null;
                MessageBox.Show("Error in authorization");
            }
            }

        static public string AuthorizationUserId(string login)
        {
            try
            {
                DataBase.msCommand.CommandText = @"select id from user where username = '" + login + "'";
                Object result = DataBase.msCommand.ExecuteScalar();
                user_id = result.ToString();
                return user_id;
            }
            catch 
            {
                return null;
            }
        }

        static public string AuthorizationUserGroupId(string login)
        {
            try
            {
                DataBase.msCommand.CommandText = @"select group_id from user where username = '" + login + "'";
                Object result = DataBase.msCommand.ExecuteScalar();
                group_id = result.ToString();
                return group_id;
            }
            catch
            {
                MessageBox.Show("AuthorizationUserGroupId");
                return null;
            }
        }

        static public int GetUtilityId(string name)
        {
            try
            {
                DataBase.msCommand.CommandText = @"select utility_id from utility where name = '" + name + "'";
                Object result = DataBase.msCommand.ExecuteScalar();
                utility_id = result.ToString();
                return 0;
            }
            catch
            {
                MessageBox.Show("AuthorizationUserGroupId");
                return 0;
            }
        }
    }



}
