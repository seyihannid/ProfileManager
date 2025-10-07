namespace ProfileManager.Models
{
    public class Airport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }
        public static List<Airport> airports = new List<Airport>
        {
            new Airport { Id = 1, Name = "Hartsfield-Jackson Atlanta International Airport", City = "Atlanta", Country = "United States", IATA = "ATL", ICAO = "KATL" },
            new Airport { Id = 2, Name = "Beijing Capital International Airport", City = "Beijing", Country = "China", IATA = "PEK", ICAO = "ZBAA" },
            new Airport { Id = 3, Name = "Dubai International Airport", City = "Dubai", Country = "United Arab Emirates", IATA = "DXB", ICAO = "OMDB"}

         };
    }
}
