using CQRS.Core.Groups.AddLector;
using CQRS.Core.Groups.AddStudent;
using CQRS.Core.Groups.ChangeBackgroundImage;
using CQRS.Core.Groups.CreateChannel;
using CQRS.Core.Groups.CreatePastExam;
using CQRS.Core.Groups.CreateUpcomingExam;
using CQRS.Core.Groups.Delete;
using CQRS.Core.Groups.GetAllChannels;
using CQRS.Core.Groups.GetAllLectors;
using CQRS.Core.Groups.GetAllPastExams;
using CQRS.Core.Groups.GetAllStudents;
using CQRS.Core.Groups.GetAllUpcomingExams;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Core;

public class GroupsController : ApiController
{
    //Groups
    public async Task<ActionResult<ChangeGroupBackgroundImageResponse>> ChangeBackgroundImage(ChangeGroupBackgroundImageCommand changeGroupBackgroundImageCommand)
        => await Mediator.Send(changeGroupBackgroundImageCommand);

    public async Task<ActionResult<DeleteGroupResponse>> DeleteGroup(DeleteGroupCommand createGroupCommand)
        => await Mediator.Send(createGroupCommand);


    //UpcomingExams
    public async Task<ActionResult<CreateUpcomingExamResponse>> CreateUpcomingExam(CreateUpcomingExamCommand createUpcomingExamCommand)
    => await Mediator.Send(createUpcomingExamCommand);

    public async Task<GetAllUpcomingExamsForAGroupResponse> GetAllUpcomingExams(GetAllUpcomingExamsForAGroupCommand getAllUpcomingExamsCommand)
        => await Mediator.Send(getAllUpcomingExamsCommand);


    //PastExams
    public async Task<ActionResult<CreatePastExamResponse>> CreatePastExam(CreatePastExamCommand createPastExamCommand)
        => await Mediator.Send(createPastExamCommand);

    public async Task<GetAllPastExamsForAGroupResponse> GetAllPastExams(GetAllPastExamsForAGroupCommand getAllUpcomingExamsCommand)
        => await Mediator.Send(getAllUpcomingExamsCommand);


    //Lectors
    public async Task<ActionResult<AddLectorRoleResponse>> AddLectorRole(AddLectorRoleCommand addLectureRoleCommand)
        => await Mediator.Send(addLectureRoleCommand);

    public async Task<ActionResult<GetAllLectorsForAGroupResponse>> GetAllLectors(GetAllLectorsForAGroupCommand getAllLectorsCommand)
        => await Mediator.Send(getAllLectorsCommand);


    //Students
    public async Task<ActionResult<AddStudentRoleResponse>> AddStudentRole(AddStudentRoleCommand addStudentCommand)
        => await Mediator.Send(addStudentCommand);

    public async Task<ActionResult<GetAllStudentsForAGroupResponse>> GetAllStudents(GetAllStudentsForAGroupCommand getAllStudentsCommand)
       => await Mediator.Send(getAllStudentsCommand);


    //Channels
    public async Task<CreateChannelResponse> CreateChannel(CreateChannelCommand createChannelCommand)
        => await Mediator.Send(createChannelCommand);

    public async Task<GetAllChannelsForAGroupResponse> GetAllChannels(GetAllChannelsForAGroupCommand getAllChannelsCommand)
        => await Mediator.Send(getAllChannelsCommand);
}
