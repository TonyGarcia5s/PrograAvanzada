// Models/Supplier.cs
namespace Practica_programada_2.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}