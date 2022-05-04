using Lea.Services.Data.Interfaces.Core;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Responses.Core.Students;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lea.Web.Handlers.Core.Students;
public class GetAllGroupsForAStudentHandler : IRequestHandler<GetAllGroupsForAStudentCommand, GetAllGroupsForAStudentResponse>
{
    private readonly IStudentsService studentsService;

    public GetAllGroupsForAStudentHandler(IStudentsService groupsService)
        => this.studentsService = groupsService;

    public Task<GetAllGroupsForAStudentResponse> Handle(GetAllGroupsForAStudentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
