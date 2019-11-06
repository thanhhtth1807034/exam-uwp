using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace exam_uwp.Utils
{
    public class SQLiteHelper
    {
        private const string DatabaseName = "Contact.db";
        private static SQLiteHelper _instance;
        public SQLiteConnection Connection { get; }

        public static SQLiteHelper GetInstances()
        {
            if (_instance == null)
            {
                _instance = new SQLiteHelper();
            }

            return _instance;
        }

        private SQLiteHelper()
        {
            Connection = new SQLiteConnection(DatabaseName);
            CreateTables();
        }

        private void CreateTables()
        {
            string sql =
                @"CREATE TABLE IF NOT EXISTS Contact (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, Name VARCHAR( 140 ), PhoneNumber VARCHAR UNIQUE);";
            using (var statement = Connection.Prepare(sql))
            {
                statement.Step();
            }
            
        }
    }
}
