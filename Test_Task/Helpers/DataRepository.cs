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
    public class DataRepository 
    {
        string connectionString = null;

        public DataRepository(string conn)
        {
            connectionString = conn;
        }

        public List<object> RequestCheck(SQLRequest sql)
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
                    var s = GetTableName(chacked);
                    string z = "SELECT * FROM " + s;
                    return GetData(z);
                }
            }
            catch (Exception e)
            {
                
                return new List<object>();
            }
        }

        public bool Select(string[] a)
        {
            return a.Contains("Select") ? true : (a.Contains("SELECT") ? true : a.Contains("select"));
        }
        public bool Insert(string[] a)
        {
            return a.Contains("Insert") ? true : (a.Contains("INSERT") ? true : a.Contains("insert"));
        }

        public bool Delete(string[] a)
        {
            return a.Contains("DELETE") ? true : (a.Contains("Delete") ? true : a.Contains("delete"));
        }

        public bool Update(string[] a)
        {
            return a.Contains("UPDATE") ? true : (a.Contains("Update") ? true : a.Contains("update"));
        }

        public string GetTableName(string[] a)
        {
            if (Insert(a) || Delete(a))
            {
                return a[2];
            }
            else return a[1];
        }
        public List<object> GetData(string TableName)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query(TableName).ToList();
            }
        }
        public List<object> Get(string sql)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query(sql).ToList();
            }
        }

        public List<object> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query("SELECT * FROM Users").ToList();
            }
        }
    }
}
