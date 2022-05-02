using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;

namespace Lea.Web.Controllers.Core;

public class LectorsController : ApiController
{
    public async Task<AddLectorResponse> AddLector(AddLectorCommand addLectureRoleCommand)
        => await this.Mediator.Send(addLectureRoleCommand);

    public async Task<DeleteLectorResponse> DeleteLector(DeleteLectorCommand deleteLectorRoleCommand)
        => await this.Mediator.Send(deleteLectorRoleCommand);

    public async Task<GetLectorResponse> GetLector(GetLectorCommand getLectorCommand)
        => await this.Mediator.Send(getLectorCommand);

    public async Task<GetAllLectorsResponse> GetAllLectors(GetAllLectorsCommand getAllLectorsCommand)
        => await this.Mediator.Send(getAllLectorsCommand);
}
