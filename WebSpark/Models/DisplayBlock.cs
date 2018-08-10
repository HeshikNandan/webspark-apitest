using System;
namespace WebSpark.Models
{
    public class DisplayBlock
    {
        public DisplayBlock()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
