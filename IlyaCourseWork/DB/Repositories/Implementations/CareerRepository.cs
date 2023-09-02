using IlyaCourseWork.DB;
using IlyaCourseWork.DB.Entity;
using IlyaCourseWork.DB.Repositories.Interfaces;

namespace IlyaCourseWork.DB.Repositories.Implementations
{
    public class CareerRepository : IBaseRepository<Career>
    {
        private readonly ApplicationDbContext _db;

        public CareerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Career> GetAll()
        {
            return _db.Careers;
        }
    }
}
