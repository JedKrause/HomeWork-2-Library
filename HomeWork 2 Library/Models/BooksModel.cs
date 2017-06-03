using System.ComponentModel.DataAnnotations;
namespace HomeWork_1_Library.Models
{
    public class BooksModel
    {
        [Required(ErrorMessage = "Please enter Book Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Author Name")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Please enter Book ISBN")]
        public string ISBN { get; set; }        
    }
}