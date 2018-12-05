namespace KSS.DataLayer.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public Employee Employee { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Number { get; set; }  
        public string AlternativeNumber { get; set; }

    }
}