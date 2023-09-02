using IlyaCourseWork.DB;
using IlyaCourseWork.DB.Entity;
using IlyaCourseWork.DB.Repositories.Interfaces;

namespace IlyaCourseWork.DB.Repositories.Implementations
{
    public class MediaRepository : IBaseRepository<Media>
    {
        private readonly ApplicationDbContext _db;

        public MediaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Media> GetAll()
        {
            return _db.Medias;
        }
    }
}
