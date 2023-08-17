namespace WebProject.Core.Models.Room
{
    using Microsoft.AspNetCore.Http;

    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Data.Models.Room;
    using Views.Room.Auxiliary;

    using static Common.DataConstants.DataConstants.Room;

    public class EditRoomViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), PricePerNightMinValue, PricePerNightMaxValue)]
        public decimal PricePerNight { get; set; }

        [Required]
        public Guid BedId { get; set; }

        [Required]
        public Guid RoomTypeId { get; set; }

        public IFormFileCollection? Files { get; set; }

        public IEnumerable<Bed>? Beds { get; set; }

        public IEnumerable<RoomType>? RoomTypes { get; set; }

        public IEnumerable<CheckboxOption>? Checkboxes { get; set; }

        public IEnumerable<string> UniqueName { get; set; } = null!;
    }
}
