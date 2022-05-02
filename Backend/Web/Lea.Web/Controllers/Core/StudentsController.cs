using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;

namespace Lea.Web.Controllers.Core;

public class StudentsController : ApiController
{
    public async Task<AddStudentResponse> AddStudent(AddStudentCommand addStudentCommand)
        => await this.Mediator.Send(addStudentCommand);

    public async Task<DeleteStudentResponse> DeleteStudent(DeleteStudentCommand deleteStudentCommand)
        => await this.Mediator.Send(deleteStudentCommand);

    public async Task<GetStudentResponse> GetStudent(GetStudentCommand getStudentCommand)
        => await this.Mediator.Send(getStudentCommand);

    public async Task<GetAllStudentsResponse> GetAllStudents(GetAllStudentsCommand getAllStudentsCommand)
        => await this.Mediator.Send(getAllStudentsCommand);
}
