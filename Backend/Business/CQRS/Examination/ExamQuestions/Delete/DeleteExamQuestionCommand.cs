using MediatR;

namespace CQRS.Examination.ExamQuestions.Delete;

public class DeleteExamQuestionCommand : IRequest<DeleteExamQuestionResponse>
{
}