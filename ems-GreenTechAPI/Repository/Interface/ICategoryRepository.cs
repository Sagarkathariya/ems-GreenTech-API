using ems_GreenTechAPI.Models.Domain;

namespace ems_GreenTechAPI.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category); 
    }
}
