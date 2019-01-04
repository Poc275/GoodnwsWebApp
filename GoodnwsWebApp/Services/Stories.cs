using GoodnwsWebApp.Models;
using System.Linq;

namespace GoodnwsWebApp.Services
{
    public class Stories : IStories
    {
        private readonly GoodnwsDbContext _context;

        public Stories(GoodnwsDbContext context)
        {
            _context = context;
        }

        public void FlagStory(string url)
        {
            Story story = _context.Stories.SingleOrDefault(sto => sto.Link == url);
            if(story != null)
            {
                story.Flagged++;
                _context.SaveChanges();
            }
        }

        public Story Get(string url)
        {
            return _context.Stories.FirstOrDefault(story => story.Link == url);
        }

        public IQueryable<Story> GetStories(int page)
        {
            int take = 10;
            int skip = page * take;

            return _context.Stories.OrderByDescending(s => s.Date)
                .Skip(skip)
                .Take(take);
        }

        public int GetTotalNumberOfStories()
        {
            return _context.Stories.Count();
        }
    }
}
