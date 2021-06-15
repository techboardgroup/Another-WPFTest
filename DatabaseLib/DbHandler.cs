using DatabaseLib.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib
{
    public class DatabaseHandler
    {

        private SQLiteConnection _db;

        public DatabaseHandler()
        {

            _db = new SQLiteConnection("./test.db");
            _db.CreateTable<Stock>();
            _db.CreateTable<Valuation>();

            var stock = new Stock
            {
                Symbol = "MSFT"
            };

            _db.Insert(stock);

            var stocks = _db.Query<Stock>("SELECT * FROM Stocks");

            foreach (var singleStock in stocks)
            {
                Console.WriteLine(singleStock.Symbol);
            }
        }

        public void AddCategory()
        {

        }
    }
}
