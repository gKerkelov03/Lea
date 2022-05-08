using MediatR;

namespace CQRS.Core.Courses.ChangeBackgroundImage;

public class ChangeCourseBackgroundImageCommand : IRequest<ChangeCourseBackgroundImageResponse>
{
    public Guid CourseId { get; set; }

    public string PictureUrl { get; set; }
}