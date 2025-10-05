namespace ProfileManager.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public long Population { get; set; }
        public double Area { get; set; }

        public static List<Country> countries = new List<Country>
            {
            new Country { Id = 1, Name = "United States", Code = "US", Capital = "Washington, D.C.", Region = "Americas", Population = 331002651, Area = 9833520 },
            new Country { Id = 2, Name = "Canada", Code = "CA", Capital = "Ottawa", Region = "Americas", Population = 37742154, Area = 9984670 },
            new Country { Id = 3, Name = "Germany", Code = "DE", Capital = "Berlin", Region = "Europe", Population = 83783942, Area = 357022 }
        };

    }

}
