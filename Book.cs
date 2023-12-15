using System;
using System.ComponentModel.DataAnnotations;

namespace sp19Homework5Example.Models
{
    public class Book
    {
        //Primary key
        public Int32 BookID { get; set; }

        //Navigational properties
        public String Title { get; set; }
        public String Author { get; set; }
        public String Description { get; set; }

        [Display(Name = "Date Released")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Price { get; set; }

        public Genre Genre { get; set; }
    }
}
