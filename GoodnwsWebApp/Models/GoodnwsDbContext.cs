using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodnwsWebApp.Models
{
    public class GoodnwsDbContext : DbContext
    {
        public GoodnwsDbContext(DbContextOptions<GoodnwsDbContext> options) : base(options)
        {
        }

        public DbSet<Story> Stories { get; set; }

        // seed the db with some data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Story>().HasData(new Story
            {
                Link = "http://feeds.reuters.com/~r/Reuters/UKTopNews/~3/ibz6VwkwsDI/please-no-brexit-talk-merkel-macron-hit-the-bar-for-beer-and-fries-idUKKCN1MS1CX",
                Title = "Please, no Brexit talk: Merkel, Macron hit the bar for beer and fries",
                Description = "Angela Merkel, Emmanuel Macron and the leaders of Belgium and Luxembourg surprised late-night drinkers by dropping by a Brussels bar for beer and fries after an evening of summitry on Brexit with British Prime Minister Theresa May.",
                Summary = "Angela Merkel, Emmanuel Macron and the leaders of Belgium and Luxembourg surprised late-night drinkers by dropping by a Brussels bar for beer and fries after an evening of summitry on Brexit with British Prime Minister Theresa May.",
                Date = new DateTime(2018, 10, 18, 9, 52, 0),
                Source = "Reuters: Top News",
                Confidence = 0.75f,
                Flagged = 0
            });

            modelBuilder.Entity<Story>().HasData(new Story
            {
                Link = "http://www.independent.co.uk/news/uk/home-news/bristol-university-cleaner-students-jamaica-holiday-herman-gordon-a8544936.html",
                Title = "Bristol University cleaner enjoys holiday to Jamaica paid for by students",
                Description = "Long-serving staff member shares pictures from the trip with his wife Denise",
                Summary = "Long-serving staff member shares pictures from the trip with his wife Denise",
                Image = "https://static.independent.co.uk/s3fs-public/styles/feed/public/thumbnails/image/2018/09/19/13/gordon.jpg",
                Date = new DateTime(2018, 9, 19, 16, 54, 0),
                Source = "The Independent - UK",
                Confidence = 0.99f,
                Flagged = 0
            });

            modelBuilder.Entity<Story>().HasData(new Story
            {
                Link = "http://www.independent.co.uk/news/uk/home-news/dolphins-filmed-jumping-for-joy-cornwall-cornish-coast-heatwave-weather-lands-end-a8416351.html",
                Title = "Dolphins filmed jumping for joy off Cornish coast as Britain basks in heatwave",
                Description = "The pod of bottlenoses followed tourist boat for more than a mile",
                Summary = "The pod of bottlenoses followed tourist boat for more than a mile",
                Date = new DateTime(2018, 6, 25, 17, 28, 0),
                Image = "https://static.independent.co.uk/s3fs-public/styles/feed/public/thumbnails/image/2018/06/25/16/splashing-time-173308.jpg",
                Source = "The Independent - UK",
                Confidence = 0.82f,
                Flagged = 0
            });

            modelBuilder.Entity<Story>().HasData(new Story
            {
                Link = "http://feeds.reuters.com/~r/Reuters/UKTopNews/~3/22D9saZ5EOM/sealed-with-a-kiss-newlyweds-harry-and-meghan-delight-windsor-crowds-idUKKCN1IJ2VX",
                Title = "Sealed with a kiss - newlyweds Harry and Meghan delight Windsor crowds",
                Description = "WINDSOR, England (Reuters) - Prince Harry and his bride Meghan married on Saturday in a dazzling ceremony that blended ancient English ritual with African American culture, watched up close by royals and celebrities and from afar by a global TV audience...",
                Summary = "WINDSOR, England (Reuters) - Prince Harry and his bride Meghan married on Saturday in a dazzling ceremony that blended ancient English ritual with African American culture, watched up close by royals and celebrities and from afar by a global TV audience of millions.",
                Date = new DateTime(2018, 5, 19, 15, 32, 0),
                Image = "s3.reutersmedia.net/resources/r/?m=02&d=20180519&t=2&i=1263743607&r=LYNXNPEE4I0E6&w=1200",
                Source = "Reuters: Top News",
                Confidence = 0.77f,
                Flagged = 0
            });

            modelBuilder.Entity<Story>().HasData(new Story
            {
                Link = "http://www.bbc.co.uk/news/uk-northern-ireland-43802862",
                Title = "County Antrim cows jump for joy after winter indoors",
                Description = "Cows in Glarryford, County Antrim, taste freedom as they are released into a field after winter indoors.",
                Summary = "Cows in Glarryford, County Antrim, taste freedom as they are released into a field after winter indoors.",
                Date = new DateTime(2018, 4, 17, 17, 47, 0),
                Image = "http://c.files.bbci.co.uk/16B8F/production/_100917039_p064ldwk.jpg",
                Source = "BBC News - UK",
                Confidence = 0.9f,
                Flagged = 0
            });
        }
    }
}
