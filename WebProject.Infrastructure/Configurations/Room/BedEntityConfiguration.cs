namespace WebProject.Infrastructure.Configurations.Room
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Room;

    public class BedEntityConfiguration : IEntityTypeConfiguration<Bed>
    {
        public void Configure(EntityTypeBuilder<Bed> builder)
        {
            builder.HasData(SeedBeds());
        }

        private List<Bed> SeedBeds()
        {
            List<Bed> beds = new List<Bed>();

            Bed bed = new Bed()
            {
                Id = Guid.Parse("6622B98E-2130-4633-B227-23DE72BC0021"),
                TypeName = "King Bed",
                IsDeleted = false
            };

            beds.Add(bed);

            bed = new Bed()
            {
                Id = Guid.Parse("7A644AEA-E74A-49E2-BAEE-804A178A00B7"),
                TypeName = "Queen Bed",
                IsDeleted = false
            };

            beds.Add(bed);

            bed = new Bed()
            {
                Id = Guid.Parse("CE9A5733-71B4-4D67-B0CD-01E909031D12"),
                TypeName = "Bunk Bed",
                IsDeleted = false
            };

            beds.Add(bed);

            return beds;
        }
    }
}
