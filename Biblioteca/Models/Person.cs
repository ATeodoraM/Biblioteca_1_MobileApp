using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
    public class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string FirstName { get; set; }
        [NotNull]
        public string LastName { get; set; }
        [NotNull]
        public int Age { get; set; }
        [NotNull]
        public int Student { get; set; }
    }
}
