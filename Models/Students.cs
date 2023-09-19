namespace ArrestTracker.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } //= string.Empty;
        public string? Occupation { get; set; }
        public int Age { get; set; }
        public string? ArrestLocation { get; set; }
        public DateTime Arrested { get; set; }
        public DateTime Released { get; set; }
        public bool isReleased { get; set; }
       // public Officers officers { get; set; } = new Officers();
    }
}
