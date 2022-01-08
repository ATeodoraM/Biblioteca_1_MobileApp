using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
   public class BookCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Book))]
        public int Book_ID { get; set; }

        [ForeignKey(typeof(Category))]
        public int Catgeory_ID { get; set; }
        
    }
}
