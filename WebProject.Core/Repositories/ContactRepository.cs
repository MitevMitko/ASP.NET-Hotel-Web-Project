namespace WebProject.Core.Repositories
{
    using IRepositories;
    using Infrastructure.Data.Models.Contact;
    using Infrastucture.Data;

    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext context) : base(context) { }
    }
}
