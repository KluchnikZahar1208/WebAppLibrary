using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        public string Iban { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime TimeTaken { get; set; }

        public DateTime TimeReturned { get; set; }

    }
}
