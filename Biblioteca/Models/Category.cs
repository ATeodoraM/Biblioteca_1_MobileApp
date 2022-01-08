using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
  public class Category
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
