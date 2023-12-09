using ems_GreenTechAPI.Models.Domain;
using ems_GreenTechAPI.Models.DTO;

namespace ems_GreenTechAPI.Repository.Interface
{
    public interface ICategoryRepository {
        //object category { get; set; }

        Task<Category> CreateAsync(Category category);
        IEnumerable<CategoryDto> GetAllCategories();
        //Task<Category> UpdateAsync(Category category);

       //Task<List<Category>> GetAllCategories(Category category);
        //Task<Category> GetAsync(Category category);
    }

   // public  interface ICategoryGetAll {
       // Task<IEnumerable<CategoryDto>> GetAllAsync();
        //Task<Category> GetAll(Category category);

    //}
}
