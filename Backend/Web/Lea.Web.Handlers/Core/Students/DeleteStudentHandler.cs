using Lea.Web.Commands.Core.Courses;
using Lea.Web.Responses.Core.Courses;
using MediatR;

namespace Lea.Web.Handlers.Core.Students;

public class DeleteStudentHandler : IRequestHandler<ChangeCourseBackgroundImageCommand, ChangeCourseBackgroundImageResponse>
{
    public Task<ChangeCourseBackgroundImageResponse> Handle(ChangeCourseBackgroundImageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}