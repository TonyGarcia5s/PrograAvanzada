// Services/ISupplierService.cs
using Practica_programada_2.Models;

namespace Practica_programada_2.Services
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetAllAsync();
        Task<Supplier?> GetByIdAsync(int id);
        Task CreateAsync(Supplier supplier);
        Task UpdateAsync(Supplier supplier);
        Task DeleteAsync(int id);
    }
}