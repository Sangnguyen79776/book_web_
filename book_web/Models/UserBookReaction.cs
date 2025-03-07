using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace book_web.Models
{
  
    public class UserBookReaction

    {
        public int Id { get; set; }
        public string UserId { get; set; }  // User that liked or disliked the book
        public int BookId { get; set; }     // Book that was liked or disliked
        public bool? Liked { get; set; }     // True if the user liked, false if the user disliked

        public IdentityUser User { get; set; }
        public Book Book { get; set; }
    }
}
