using System;
using System.ComponentModel.DataAnnotations;

namespace Books_Blog.Models
{
    public class Book
    {
        //自動プロパティ定義
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Genre { get; set; }
 
    }

}

