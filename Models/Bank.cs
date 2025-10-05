namespace ProfileManager.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string SWIFT { get; set; }
        public string Address { get; set; }
        public static List<Bank> banks = new List<Bank>
          {
               new Bank { Id = 1, Name = "Bank of America", Code = "BOA", Country = "United States", SWIFT = "BOFAUS3N", Address = "100 N Tryon St, Charlotte, NC 28255" },
               new Bank { Id = 2, Name = "HSBC", Code = "HSBC", Country = "United Kingdom", SWIFT = "MIDLGB22", Address = "8 Canada Square, London E14 5HQ" },
               new Bank { Id = 3, Name = "Deutsche Bank", Code = "DB", Country = "Germany", SWIFT = "DEUTDEFF", Address = "Taunusanlage 12, 60325 Frankfurt am Main" }
          };
    }
}
