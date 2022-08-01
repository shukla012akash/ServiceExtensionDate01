using DependencyInjectionSample01.Models;

namespace DependencyInjectionSample01.Repository
{
    public interface IMovieRepository
    {
        
    List<Movie> GetAll();
        Movie GetByID(int id);
    }

}
