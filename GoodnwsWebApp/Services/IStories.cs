using GoodnwsWebApp.Models;
using System.Linq;

namespace GoodnwsWebApp.Services
{
    public interface IStories
    {
        IQueryable<Story> GetStories();

        Story Get(string url);
    }
}
