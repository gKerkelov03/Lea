using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class GetAllLectorsHandler : IRequestHandler<GetAllLectorsCommand, GetAllLectorsResponse>
{
    private readonly ILectorsService groupsService;

    public GetAllLectorsHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllLectorsResponse> Handle(GetAllLectorsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}