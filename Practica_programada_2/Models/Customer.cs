// Models/Customer.cs
namespace Practica_programada_2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}