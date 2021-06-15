using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Tables
{
    [Table("Valuation")]
    public class Valuation
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Indexed]
        [Column("stock_id")]
        public int StockId { get; set; }

        [Column("time")]
        public DateTime Time { get; set; }

        [Column("price")]
        public decimal Price { get; set; }
    }
}
