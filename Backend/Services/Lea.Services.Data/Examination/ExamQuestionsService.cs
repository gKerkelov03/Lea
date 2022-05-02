﻿using AutoMapper;
using Lea.Data.Entities.Examination;
using Lea.Data.Repositories.Examination;
using Lea.Services.Data.Interfaces.Examination;
using Lea.Services.Data.Models.Examination;

namespace Lea.Services.Data.Examination;

public class ExamQuestionsService : BaseDataService<ExamQuestion, ExamQuestionServiceModel, ExamQuestionsRepository>, IExamQuestionsService
{
    public ExamQuestionsService(ExamQuestionsRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}
