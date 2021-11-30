using Examination.Dtos;
using Examination.Dtos.Exams;
using MediatR;
using System.Collections.Generic;

namespace Examination.Application.Queries.V1.Exams.GetHomeExamList
{
    public class GetHomeExamListQuery : IRequest<IEnumerable<ExamDto>>
    {
    }
}