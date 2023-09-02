using IlyaCourseWork.DB;
using IlyaCourseWork.DB.Entity;
using IlyaCourseWork.DB.Repositories.Interfaces;

namespace IlyaCourseWork.DB.Repositories.Implementations
{
    public class AboutRepository : IBaseRepository<About>
    {
        private readonly ApplicationDbContext _db;

        public AboutRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<About> GetAll()
        {
            return _db.Abouts;
        }
    }
}
