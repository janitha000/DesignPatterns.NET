using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AroundWithLambda
{
    class Database
    {
        private Database()
        {
            Console.WriteLine("Database created");              
        }

        public void Query1()
        {
            Console.WriteLine("Query1 executed");
        }

        public void Query2()
        {
            Console.WriteLine("Query2 executed");
        }

        private void CleanUp()
        {
            Console.WriteLine("Cleanup...");        
        }

        public static void Create(Action<Database> execution)
        {
            Database db = new Database();
            try
            {
                execution(db);
            }
            finally
            {
                db.CleanUp();
            }
        }
    }
}
