using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
    public class BorrowedBook
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [NotNull]
        public int BookReturned { get; set; }
        [NotNull]
        public DateTime BorrowedDate { get; set; }

        public DateTime ReturnDate {get; set;}

        [ForeignKey(typeof(Person))]
        public int Person_ID { get; set; }

        [ForeignKey(typeof(Book))]
        public int Book_ID { get; set; }

        
    }
}
