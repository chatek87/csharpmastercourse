using System.ComponentModel.DataAnnotations;

namespace MVCMessageWall.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Yo this is a message")]
        public string Message { get; set; }
    }
}
