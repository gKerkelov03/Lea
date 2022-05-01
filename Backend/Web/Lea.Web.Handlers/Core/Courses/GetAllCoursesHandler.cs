using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class GetAllCoursesHandler : IRequestHandler<GetAllCoursesCommand, GetAllCoursesResponse>
{
    public Task<GetAllCoursesResponse> Handle(GetAllCoursesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}