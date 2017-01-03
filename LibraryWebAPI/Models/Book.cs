using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWebAPI.Models
{
    public class Book
    {
        [Key] // wasnt working without this and the last 2 usings ^
        public int id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public DateTime? yearPublished { get; set; }
        public DateTime? dateLastCheckedOut { get; set; }
        public DateTime? dateDueBack { get; set; }
        public bool? isCheckedOut { get; set; }
    }
}