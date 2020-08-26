using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestBook.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [StringLength(120, MinimumLength = 3)]
        public string Coment { get; set; }
        
        [ForeignKey("Owner")]
        public int OwnerId { get; set; }

        public GuestBook Owner { get; set; }
    }
}