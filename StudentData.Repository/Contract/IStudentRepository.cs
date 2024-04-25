using StudentData.Entity.Models;

namespace StudentData.Repository.Contract
{
    public class IStudentRepository
    {
        Task<List<StudentMaster>> GetList();
        Task<StudentMaster> GetById(Guid id);
    }
}
