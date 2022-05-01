using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Lectors;

public class GetLectorHandler : IRequestHandler<ChangeCourseBackgroundImageCommand, ChangeCourseBackgroundImageResponse>
{
    public Task<ChangeCourseBackgroundImageResponse> Handle(ChangeCourseBackgroundImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}