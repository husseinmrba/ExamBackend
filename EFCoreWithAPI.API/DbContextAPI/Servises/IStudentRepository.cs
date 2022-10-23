using EFCoreWithAPI.API.Models;

namespace EFCoreWithAPI.API.DbContextAPI.Servises
{
    public interface IStudentRepository
    {
        Task<(List<Student>, PaginationMetaData)> GetStudentsAsync(int pageNumber , int pageSize, string? keyword);
        Task<Student> GetStudentByIdAsync(int id);
    }
}
