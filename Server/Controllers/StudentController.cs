using ContosoUniversity.Server.Interfaces;
using ContosoUniversity.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _IStudent;
        public StudentController(IStudent iStudent)
        {
            _IStudent = iStudent;
        }
        [HttpGet]
        public async Task<List<Student>> Get()
        {
            return await Task.FromResult(_IStudent.GetUserDetails());
        }
    }
}