namespace WebProject.Infrastructure.Data.Models.Contact
{
    using System.ComponentModel.DataAnnotations;

    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [Phone]
        public string Phone { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }
    }
}
