namespace book_web.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string Yourname {  get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string MapEmbedCode { get; set; }  // Embedded Google Map HTML code
    }
}
