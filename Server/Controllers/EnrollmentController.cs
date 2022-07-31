using ContosoUniversity.Server.Interfaces;
using ContosoUniversity.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollment _IEnrollment;
        public EnrollmentController(IEnrollment iEnrollment)
        {
            _IEnrollment = iEnrollment;
        }
        [HttpGet]
        public async Task<List<Enrollment>> Get()
        {
            return await Task.FromResult(_IEnrollment.GetUserDetails());
        }
    }
}