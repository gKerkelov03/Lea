using MediatR;

namespace CQRS.Examination.ExamQuestions.Get;

public class GetExamQuestionCommand : IRequest<GetExamQuestionResponse>
{
}