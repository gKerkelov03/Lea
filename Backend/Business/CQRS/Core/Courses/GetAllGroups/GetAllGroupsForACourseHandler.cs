using Business.Interfaces.Data.Core;
using MediatR;

namespace CQRS.Core.Courses.GetAllGroups;

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