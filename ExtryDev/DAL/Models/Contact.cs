namespace ExtryDev.DAL.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string SendDate { get; set; }
    }
}
