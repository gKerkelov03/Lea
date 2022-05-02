using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class AddLectorHandler : IRequestHandler<AddLectorCommand, AddLectorResponse>
{
    private readonly ILectorsService groupsService;

    public AddLectorHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<AddLectorResponse> Handle(AddLectorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}