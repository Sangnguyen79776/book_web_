namespace book_web.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }      // Title of the event (e.g., "Book Signing with Author XYZ")
        public string Description { get; set; }  // Description of the event
        public DateTime Date { get; set; }      // Date and time of the event
        public string Location { get; set; }    // Event location
        public string ImageUrl { get; set; }    // Optional image for the event
    }
}
