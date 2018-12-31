using System;
using System.ComponentModel.DataAnnotations;

namespace GoodnwsWebApp.Models
{
    public class Story
    {
        [Key]
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Source { get; set; }
        public float Confidence { get; set; }
        public int Votes { get; set; }
    }
}
