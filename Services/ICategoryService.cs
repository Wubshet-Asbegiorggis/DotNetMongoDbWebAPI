using MongoDotnetDemo.Models;

namespace MongoDotnetDemo.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsyc();
        Task<Category> GetById(string id);
        Task CreateAsync(Category category);
        Task UpdateAsync(string id, Category category);
        Task DeleteAysnc(string id);
    }
}