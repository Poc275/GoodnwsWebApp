using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodnwsWebApp.Migrations
{
    public partial class AddedSeedDataToStoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Link", "Confidence", "Date", "Description", "Image", "Source", "Summary", "Title", "Votes" },
                values: new object[,]
                {
                    { "http://feeds.reuters.com/~r/Reuters/UKTopNews/~3/ibz6VwkwsDI/please-no-brexit-talk-merkel-macron-hit-the-bar-for-beer-and-fries-idUKKCN1MS1CX", 0.75f, new DateTime(2018, 10, 18, 9, 52, 0, 0, DateTimeKind.Unspecified), "Angela Merkel, Emmanuel Macron and the leaders of Belgium and Luxembourg surprised late-night drinkers by dropping by a Brussels bar for beer and fries after an evening of summitry on Brexit with British Prime Minister Theresa May.", null, "Reuters: Top News", "Angela Merkel, Emmanuel Macron and the leaders of Belgium and Luxembourg surprised late-night drinkers by dropping by a Brussels bar for beer and fries after an evening of summitry on Brexit with British Prime Minister Theresa May.", "Please, no Brexit talk: Merkel, Macron hit the bar for beer and fries", 0 },
                    { "http://www.independent.co.uk/news/uk/home-news/bristol-university-cleaner-students-jamaica-holiday-herman-gordon-a8544936.html", 0.99f, new DateTime(2018, 9, 19, 16, 54, 0, 0, DateTimeKind.Unspecified), "Long-serving staff member shares pictures from the trip with his wife Denise", "https://static.independent.co.uk/s3fs-public/styles/feed/public/thumbnails/image/2018/09/19/13/gordon.jpg", "The Independent - UK", "Long-serving staff member shares pictures from the trip with his wife Denise", "Bristol University cleaner enjoys holiday to Jamaica paid for by students", 0 },
                    { "http://www.independent.co.uk/news/uk/home-news/dolphins-filmed-jumping-for-joy-cornwall-cornish-coast-heatwave-weather-lands-end-a8416351.html", 0.82f, new DateTime(2018, 6, 25, 17, 28, 0, 0, DateTimeKind.Unspecified), "The pod of bottlenoses followed tourist boat for more than a mile", "https://static.independent.co.uk/s3fs-public/styles/feed/public/thumbnails/image/2018/06/25/16/splashing-time-173308.jpg", "The Independent - UK", "The pod of bottlenoses followed tourist boat for more than a mile", "Dolphins filmed jumping for joy off Cornish coast as Britain basks in heatwave", 0 },
                    { "http://feeds.reuters.com/~r/Reuters/UKTopNews/~3/22D9saZ5EOM/sealed-with-a-kiss-newlyweds-harry-and-meghan-delight-windsor-crowds-idUKKCN1IJ2VX", 0.77f, new DateTime(2018, 5, 19, 15, 32, 0, 0, DateTimeKind.Unspecified), "WINDSOR, England (Reuters) - Prince Harry and his bride Meghan married on Saturday in a dazzling ceremony that blended ancient English ritual with African American culture, watched up close by royals and celebrities and from afar by a global TV audience...", "s3.reutersmedia.net/resources/r/?m=02&d=20180519&t=2&i=1263743607&r=LYNXNPEE4I0E6&w=1200", "Reuters: Top News", "WINDSOR, England (Reuters) - Prince Harry and his bride Meghan married on Saturday in a dazzling ceremony that blended ancient English ritual with African American culture, watched up close by royals and celebrities and from afar by a global TV audience of millions.", "Sealed with a kiss - newlyweds Harry and Meghan delight Windsor crowds", 0 },
                    { "http://www.bbc.co.uk/news/uk-northern-ireland-43802862", 0.9f, new DateTime(2018, 4, 17, 17, 47, 0, 0, DateTimeKind.Unspecified), "Cows in Glarryford, County Antrim, taste freedom as they are released into a field after winter indoors.", "http://c.files.bbci.co.uk/16B8F/production/_100917039_p064ldwk.jpg", "BBC News - UK", "Cows in Glarryford, County Antrim, taste freedom as they are released into a field after winter indoors.", "County Antrim cows jump for joy after winter indoors", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Link",
                keyValue: "http://feeds.reuters.com/~r/Reuters/UKTopNews/~3/22D9saZ5EOM/sealed-with-a-kiss-newlyweds-harry-and-meghan-delight-windsor-crowds-idUKKCN1IJ2VX");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Link",
                keyValue: "http://feeds.reuters.com/~r/Reuters/UKTopNews/~3/ibz6VwkwsDI/please-no-brexit-talk-merkel-macron-hit-the-bar-for-beer-and-fries-idUKKCN1MS1CX");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Link",
                keyValue: "http://www.bbc.co.uk/news/uk-northern-ireland-43802862");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Link",
                keyValue: "http://www.independent.co.uk/news/uk/home-news/bristol-university-cleaner-students-jamaica-holiday-herman-gordon-a8544936.html");

            migrationBuilder.DeleteData(
                table: "Stories",
                keyColumn: "Link",
                keyValue: "http://www.independent.co.uk/news/uk/home-news/dolphins-filmed-jumping-for-joy-cornwall-cornish-coast-heatwave-weather-lands-end-a8416351.html");
        }
    }
}
