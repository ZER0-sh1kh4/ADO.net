using ONEtoONEapi.DTOS;
namespace ONEtoONEapi.Services
{
    public interface IStudentService
    {
        void AddStudent(AddStudent dto);
        void DeleteStudent(int id);
        void ChangeRoom(UpdateStudent dto);
        List<ViewAll> GetAllStudents();
        List<ViewAll> GetAllHostelStudents();
    }
}
