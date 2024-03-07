using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Singleton
{
    public class Database
    {
        private static Database _database;

        private Database()
        {
            Console.WriteLine("Database connection established");
        }

        public static Database GetDatabaseInstance()//only access point to class object
        {
            if(_database == null)
                _database = new Database();

            return _database;
        }

        public void query(string query)//some bussiness logic
        {
            Console.WriteLine($"Query <'{query}'> send to Database");
        }
    }
}
