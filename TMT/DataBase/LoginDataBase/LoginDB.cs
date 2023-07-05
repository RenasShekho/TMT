using Dapper;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMT.DataBase.LoginDataBase
{
    public class LoginDB
    {
        public static DataAccessReturnCodes FindUserForLogin()
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(Helper.CnnVal("TMT")))
                    var input = connection.Query<User>($"dbo.LoginTable @Email, @Password", new { Email = Email, Password = Password }).FirstOrDefault();
                if(input != null)
                {

                }
            }
            catch { }

        }
    }
}
