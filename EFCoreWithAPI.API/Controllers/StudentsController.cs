using EFCoreWithAPI.API.DbContextAPI.Servises;
using EFCoreWithAPI.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text.Json;

namespace EFCoreWithAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly int MaxPageSize = 10;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents(int pageNumber = 1 , int pageSize = 5, string? keyword = null)
        {
            if (pageSize > MaxPageSize)
            {
                pageSize = MaxPageSize;
            }
            var (students, paginationMetaData) = await _studentRepository.GetStudentsAsync(pageNumber, pageSize, keyword);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetaData));
            return Ok(students);
        }


        //[HttpGet]
        //public async Task<ActionResult<List<Student>>> GetStudents()
        //{
        //    var students = await _studentRepository.GetStudentsAsync();
        //    return Ok(students);
        //}

        [HttpGet("{studentId}")]
        public async Task<ActionResult<List<Student>>> GetStudentById(int studentId)
        {
            var student = await _studentRepository.GetStudentByIdAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
