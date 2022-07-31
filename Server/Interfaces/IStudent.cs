using ContosoUniversity.Shared.Models;

namespace ContosoUniversity.Server.Interfaces
{
    public interface IStudent
    {
        public List<Student> GetUserDetails();
        public void AddUser(Student student);
        //public void AddRandomUser();
        public void UpdateUserDetails(Student student);
        public Student GetUserData(int id);
        public void DeleteUser(int id);
    }
}