using SimpleBookCatalog.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookCatalog.Domain.Entities
{
    public class Book
    {
        public int ID { get; set; }
        [Required, StringLength(100)]
        public string? Title { get; set; }
        [Required, StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }
        public Category Category { get; set; }
    }
}
