using CRUD_WPF.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WPF.Database
{
    public class DatabaseHandler
    {

        private SQLiteConnection _db;

        public DatabaseHandler()
        {

            _db = new SQLiteConnection("./test.db");
            _db.CreateTable<Category>();

            var cat = new Category
            {
                Id = 3,
                Name = "pippo",
                Group = "pluto"
            };

            _db.Insert(cat);

            var cats = _db.Query<Category>("SELECT * FROM Category");

            foreach (var singleCat in cats)
            {
                Console.WriteLine(singleCat.Name);
            }
        }
    }
}
