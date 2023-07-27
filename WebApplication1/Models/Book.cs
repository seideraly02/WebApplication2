using System;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverPhoto { get; set; }
        public int YearOfManufacture { get; set; }
        public DateTime DescriptionOfTheBook { get; set; }
        public DateTime DateOfAddition { get; set; }
    }
}