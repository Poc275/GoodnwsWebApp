using GoodnwsWebApp.Models;
using System.Linq;

namespace GoodnwsWebApp.Services
{
    public interface IStories
    {
        IQueryable<Story> GetStories(int page);

        Story Get(string url);

        int GetTotalNumberOfStories();
    }
}
