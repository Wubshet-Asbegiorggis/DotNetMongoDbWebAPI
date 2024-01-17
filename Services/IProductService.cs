using MongoDotnetDemo.Models;

namespace MongoDotnetDemo.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsyc();
        Task<Product> GetById(string id);
        Task CreateAsync(Product Product);
        Task  UpdateAsync(string id, Product Product);
        Task DeleteAysnc(string id);
    }
}