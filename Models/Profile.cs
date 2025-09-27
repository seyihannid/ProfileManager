namespace ProfileManager.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public static List<Profile> profiles =
        [
            new Profile { Id = 1, FirstName = "Ade", LastName = "Tolu", Email = "ade@gmail.com", Phone = "08012345678", Address = "Lagos, Nigeria" },
            new Profile { Id = 2, FirstName = "John", LastName = "Paul", Email = "john@gmail.com", Phone = "08087654321", Address = "Abuja, Nigeria" }
        ];
    }
}