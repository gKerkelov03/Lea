using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Courses;

public class GetAllCoursesHandler : IRequestHandler<GetAllCoursesCommand, GetAllCoursesResponse>
{
    private readonly ICoursesService coursesService;

    public GetAllCoursesHandler(ICoursesService coursesService)
        => this.coursesService = coursesService;

    public Task<GetAllCoursesResponse> Handle(GetAllCoursesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}