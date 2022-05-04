using Lea.Web.Commands.Core.Groups;
using Lea.Web.Commands.Core.Lectors;
using Lea.Web.Commands.Core.Students;
using Lea.Web.Commands.Examination.PastExams;
using Lea.Web.Commands.Examination.UpcomingExams;
using Lea.Web.Commands.Messaging.Channels;
using Lea.Web.Responses.Core.Groups;
using Lea.Web.Responses.Core.Lectors;
using Lea.Web.Responses.Core.Students;
using Lea.Web.Responses.Examination.PastExams;
using Lea.Web.Responses.Examination.UpcomingExams;
using Lea.Web.Responses.Messaging.Channels;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers.Core;

public class GroupsController : ApiController
{
    public async Task<ActionResult<ChangeGroupBackgroundImageResponse>> ChangeBackgroundImage(ChangeGroupBackgroundImageCommand changeGroupBackgroundImageCommand)
        => await this.Mediator.Send(changeGroupBackgroundImageCommand);

    public async Task<ActionResult<DeleteGroupResponse>> DeleteGroup(DeleteGroupCommand createGroupCommand)
        => await this.Mediator.Send(createGroupCommand);

    public async Task<GetAllUpcomingExamsForAGroupResponse> GetAllUpcomingExams(GetAllUpcomingExamsForAGroupCommand getAllUpcomingExamsCommand)
        => await this.Mediator.Send(getAllUpcomingExamsCommand);

    public async Task<GetAllPastExamsForAGroupResponse> GetAllPastExams(GetAllPastExamsForAGroupCommand getAllUpcomingExamsCommand)
        => await this.Mediator.Send(getAllUpcomingExamsCommand);

    public async Task<ActionResult<CreatePastExamResponse>> CreatePastExam(CreatePastExamCommand createPastExamCommand)
        => await this.Mediator.Send(createPastExamCommand);

    public async Task<ActionResult<CreateUpcomingExamResponse>> CreateUpcomingExam(CreateUpcomingExamCommand createUpcomingExamCommand)
    => await this.Mediator.Send(createUpcomingExamCommand);

    public async Task<GetAllChannelsForAGroupResponse> GetAllChannels(GetAllChannelsForAGroupCommand getAllChannelsCommand)
        => await this.Mediator.Send(getAllChannelsCommand);

    public async Task<ActionResult<AddLectorRoleResponse>> AddLectorRole(AddLectorRoleCommand addLectureRoleCommand)
        => await this.Mediator.Send(addLectureRoleCommand);

    public async Task<ActionResult<GetAllLectorsForAGroupResponse>> GetAllLectors(GetAllLectorsForAGroupCommand getAllLectorsCommand)
        => await this.Mediator.Send(getAllLectorsCommand);

    public async Task<ActionResult<AddStudentRoleResponse>> AddStudentRole(AddStudentRoleCommand addStudentCommand)
        => await this.Mediator.Send(addStudentCommand);

    public async Task<ActionResult<GetAllStudentsForAGroupResponse>> GetAllStudents(GetAllStudentsForAGroupCommand getAllStudentsCommand)
       => await this.Mediator.Send(getAllStudentsCommand);

    public async Task<CreateChannelResponse> CreateChannel(CreateChannelCommand createChannelCommand)
        => await this.Mediator.Send(createChannelCommand);
}
