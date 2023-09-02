using IlyaCourseWork.DB;
using IlyaCourseWork.DB.Entity;
using IlyaCourseWork.DB.Repositories.Interfaces;

namespace IlyaCourseWork.DB.Repositories.Implementations
{
    public class ProductsRepository : IBaseRepository<Products>
    {
        private readonly ApplicationDbContext _db;

        public ProductsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Products> GetAll()
        {
            return _db.Productss;
        }
    }
}
