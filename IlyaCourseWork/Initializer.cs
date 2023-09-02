using IlyaCourseWork.DB.Entity;
using IlyaCourseWork.DB.Repositories.Implementations;
using IlyaCourseWork.DB.Repositories.Interfaces;

namespace TimurCourseWork
{
    public static class Initialization
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<About>, AboutRepository>();
            services.AddScoped<IBaseRepository<Career>, CareerRepository>();
            services.AddScoped<IBaseRepository<Media>, MediaRepository>();
            services.AddScoped<IBaseRepository<Products>, ProductsRepository>();
        }
    }
}
