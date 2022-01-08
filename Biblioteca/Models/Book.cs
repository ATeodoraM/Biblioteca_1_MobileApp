using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
   public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        [MaxLength(50)]
        public string Title { get; set;}
        [NotNull]
        [MaxLength(50)]
        public string Author { get; set; }
        [NotNull]
        public DateTime PublishingDate { get; set; }
        [NotNull]
        public int Available { get; set; }

        [ForeignKey(typeof(Publisher))]
        public int Publisher_ID { get; set; }
        [OneToMany]
        public List<ListBook> ListBooks { get; set; }
    }
}
