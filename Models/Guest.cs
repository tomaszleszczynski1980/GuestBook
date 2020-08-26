using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuestBook.Models
{
    public class Guest
    {
        public int ID { get; set; }
        
        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}