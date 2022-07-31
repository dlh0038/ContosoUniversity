using ContosoUniversity.Server.Interfaces;
using ContosoUniversity.Server.Models;
using ContosoUniversity.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Server.Services
{
    public class CourseManager : ICourse
    {
        readonly SchoolContext _dbContext = new();
        public CourseManager(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all user details
        public List<Course> GetUserDetails()
        {
            try
            {
                return _dbContext.Courses.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new user record
        public void AddUser(Course course)
        {
            try
            {
                _dbContext.Courses.Add(course);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar user
        public void UpdateUserDetails(Course course)
        {
            try
            {
                _dbContext.Entry(course).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular user
        public Course GetUserData(int id)
        {
            try
            {
                Course? course = _dbContext.Courses.Find(id);
                if (course != null)
                {
                    return course;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular user
        public void DeleteUser(int id)
        {
            try
            {
                Course? course = _dbContext.Courses.Find(id);
                if (course != null)
                {
                    _dbContext.Courses.Remove(course);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}