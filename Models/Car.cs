namespace ProfileManager.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
                
        public static List<Car> cars = new List<Car>
        {
            new Car { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Color = "Blue", VIN = "1HGBH41JXMN109186" },
            new Car { Id = 2, Make = "Honda", Model = "Civic", Year = 2019, Color = "Red", VIN = "2HGEJ6670WH543210" },
            new Car { Id = 3, Make = "Ford", Model = "Mustang", Year = 2021, Color = "Black", VIN = "1FAFP404X1F123456" }
        };
    }
}
