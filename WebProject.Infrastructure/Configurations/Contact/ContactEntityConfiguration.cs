namespace WebProject.Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models;
    using WebProject.Infrastructure.Data.Models.Contact;

    public class ContactEntityConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(SeedContacts());
        }

        private Contact SeedContacts()
        {
            Contact contact = new Contact()
            {
                Id = 1,
                Email = "LittleVienna@mail.com",
                Phone = "+359886258316"
            };

            return contact;
        }
    }
}
