
namespace ems_GreenTechAPI.Models.DTO
{
    public class CreateCategoryRequestDto
    {
        public string UrlHandle { get; set; }
        public string Name { get; set; }
        public Guid Id { get; internal set; }
    }
}
