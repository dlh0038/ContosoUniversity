using ContosoUniversity.Shared.Models;

namespace ContosoUniversity.Server.Interfaces
{
    public interface IEnrollment
    {
        public List<Enrollment> GetUserDetails();
        public void AddUser(Enrollment enrollment);
        //public void AddRandomUser();
        public void UpdateUserDetails(Enrollment enrollment);
        public Enrollment GetUserData(int id);
        public void DeleteUser(int id);
    }
}