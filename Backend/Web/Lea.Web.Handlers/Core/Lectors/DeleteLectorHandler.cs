using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Responses.Core.Lectors;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class DeleteLectorHandler : IRequestHandler<DeleteLectorCommand, DeleteLectorResponse>
{
    private readonly ILectorsService groupsService;

    public DeleteLectorHandler(ILectorsService groupsService)
        => this.groupsService = groupsService;

    public Task<DeleteLectorResponse> Handle(DeleteLectorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}