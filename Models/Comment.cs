using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestBook.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [StringLength(120, MinimumLength = 3)]
        public string Coment { get; set; }
        
        // [ForeignKey()]
        public int PostId { get; set; }
    }
}