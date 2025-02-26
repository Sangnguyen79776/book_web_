namespace book_web.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }       // Name of the team member
        public string Role { get; set; }       // Role in the bookstore (e.g., "Owner", "Manager")
        public string Bio { get; set; }        // A short bio about the team member
        public string ImageUrl { get; set; }   // Optional image URL for the team member
    }
}

