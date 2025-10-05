namespace ProfileManager.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public string Amenities { get; set; }
        public decimal PricePerNight { get; set; }
        public static List<Hotel> hotels = new List<Hotel>
        {
            new Hotel { Id = 1, Name = "Grand Plaza", Location = "New York", Rating = 5, Amenities = "Pool, Spa, Gym", PricePerNight = 299.99M },
            new Hotel { Id = 2, Name = "City Inn", Location = "Chicago", Rating = 4, Amenities = "Free WiFi, Breakfast", PricePerNight = 149.99M },
            new Hotel { Id = 3, Name = "Beachside Resort", Location = "Miami", Rating = 5, Amenities = "Beach Access, Pool", PricePerNight = 399.99M }
        };
    }
}
