using EFCoreWithAPI.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWithAPI.API.DbContextAPI.Servises
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContextAPI _context;

        public StudentRepository(AppDbContextAPI context)
        {
            _context = context;
        }
        //public async Task<List<Student>> GetStudentsAsync()
        //{
        //    var students = await _context.Students.ToListAsync();
        //    return students;
        //}

        // pagination without return information in response headers
        //public async Task<List<Student>> GetStudentsAsync(int pageNumber , int pageSize)
        //{
        //    var students = await _context.Students
        //                                 .OrderBy(t => t.FirstName)
        //                                 .Skip(pageSize * (pageNumber - 1))
        //                                 .Take(pageSize)
        //                                 .ToListAsync();
        //    return students;
        //}

        // pagination with return information in response headers with search 
        public async Task<(List<Student> , PaginationMetaData)> GetStudentsAsync(int pageNumber, int pageSize, string? keyWords)
        {
            var totalStudentCount = _context.Students.Count();
            var paginationMetaData = new PaginationMetaData(totalStudentCount,pageSize,pageNumber);

            var query = _context.Students as IQueryable<Student>;
            if (!string.IsNullOrEmpty(keyWords))
            {
                query = query.Where(t => t.FirstName.Contains(keyWords));
            }

            var students = await query
                                .OrderBy(t => t.FirstName)
                                .Skip(pageSize * (pageNumber - 1))
                                .Take(pageSize)
                                .ToListAsync();
            return (students, paginationMetaData);
        }



        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
            return student;
        }

        
    }
}
