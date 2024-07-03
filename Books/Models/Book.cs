using Books.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Books.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Title is required.")]
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [ForeignKey("AuthorId")]
        public virtual ICollection<Author>? Author {  get; set; } 
        [ForeignKey("PublisherId")]
        public virtual Publisher? Publisher { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; } 

    }
}
