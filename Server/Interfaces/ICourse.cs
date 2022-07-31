using ContosoUniversity.Shared.Models;

namespace ContosoUniversity.Server.Interfaces
{
    public interface ICourse
    {
        public List<Course> GetUserDetails();
        public void AddUser(Course course);
        //public void AddRandomUser();
        public void UpdateUserDetails(Course course);
        public Course GetUserData(int id);
        public void DeleteUser(int id);
    }
}