using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
   public class ListBook
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(BorrowedBook))]
        public int BorrowedBookID { get; set; }
        public int BookID { get; set; }
    }
}
