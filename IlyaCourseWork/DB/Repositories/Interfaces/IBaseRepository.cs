namespace IlyaCourseWork.DB.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
    }
}
