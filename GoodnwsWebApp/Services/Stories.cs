using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodnwsWebApp.Models;

namespace GoodnwsWebApp.Services
{
    public class Stories : IStories
    {
        private readonly GoodnwsDbContext _context;

        public Stories(GoodnwsDbContext context)
        {
            _context = context;
        }

        public Story Get(string url)
        {
            return _context.Stories.FirstOrDefault(story => story.Link == url);
        }

        public IQueryable<Story> GetStories()
        {
            return _context.Stories.Take(10).OrderByDescending(s => s.Date);
        }
    }
}
