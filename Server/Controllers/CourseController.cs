using ContosoUniversity.Server.Interfaces;
using ContosoUniversity.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse _ICourse;
        public CourseController(ICourse iCourse)
        {
            _ICourse = iCourse;
        }
        [HttpGet]
        public async Task<List<Course>> Get()
        {
            return await Task.FromResult(_ICourse.GetUserDetails());
        }
        
    }
}