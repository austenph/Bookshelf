using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]//primary key in Category table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}