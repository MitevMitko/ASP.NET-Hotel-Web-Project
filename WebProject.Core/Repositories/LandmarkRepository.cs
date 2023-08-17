namespace WebProject.Core.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    using IRepositories;
    using Infrastructure.Data.Models.Landmark;
    using Infrastucture.Data;

    public class LandmarkRepository : GenericRepository<Landmark>, ILandmarkRepository
    {
        public LandmarkRepository(ApplicationDbContext context) : base(context) { }
    }
}
