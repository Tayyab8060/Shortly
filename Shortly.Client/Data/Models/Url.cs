namespace Shortly.Client.Data.Models
{
    public class Url
    {
        public int Id { get; set; }
        public string OrignalLink { get; set; }
        public string ShortLink { get; set; }
        public int Clicks { get; set; }
        public int? UserId { get; set;}

        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

    }
}
