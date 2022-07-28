namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Type { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
