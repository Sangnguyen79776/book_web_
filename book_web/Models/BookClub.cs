namespace book_web.Models
{
    public class BookClub
    {
        public int Id { get; set; }
        public string Name { get; set; }      // Name of the book club
        public string Description { get; set; }  // Description of the book club
        public string JoinInstructions { get; set; }  // Instructions on how to join the club
        public DateTime MeetingDate { get; set; }   // Date and time of the next meeting
        public string Location { get; set; }     // Location of the meeting
    }
}
