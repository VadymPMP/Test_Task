using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.Helpers;

namespace Test_Task.Models
{
    public class UserRepository 
    {
        string connectionString = null;

        public UserRepository(string conn)
        {
            connectionString = conn;
        }

        public List<User> RequestCheck(SQLRequest sql)
        {
            string[] chacked = sql.Request.Split(' ');

            try {
                if (Select(chacked))
                {
                    return Get(sql.Request);
                }
                else
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.Execute(sql.Request);
                    }
                    return GetUsers();
                }
            }
            catch (Exception e)
            {
                return GetUsers();
            }
        }

        public bool Select(string[] a)
        {
            return a.Contains("Select") ? true : (a.Contains("SELECT") ? true : a.Contains("select"));
        }
        public List<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>("SELECT * FROM Users").ToList();
            }
        }
        public List<User> Get(string sql)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<User>(sql).ToList();
            }
        }
    }
}
