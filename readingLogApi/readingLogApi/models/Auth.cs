using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PinAuthApi.Models
{
    public class Auth
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string Name { get; set; }

        [Required]
        [MinLength(6)]
        public string Pin { get; set; }
    }
}