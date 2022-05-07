using Lea.Services.Interfaces.Data.Core;
using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class GetAllGroupsForACourseHandler : IRequestHandler<GetAllGroupsForACourseCommand, GetAllGroupsForACourseResponse>
{
    private readonly IGroupsService groupsService;

    public GetAllGroupsForACourseHandler(IGroupsService groupsService)
        => this.groupsService = groupsService;

    public Task<GetAllGroupsForACourseResponse> Handle(GetAllGroupsForACourseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}