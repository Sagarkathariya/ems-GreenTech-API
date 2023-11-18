
using ems_GreenTechAPI.Data;
using ems_GreenTechAPI.Models.Domain;
using ems_GreenTechAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace ems_GreenTechAPI.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return category;
        }
    }
}
