using MediatR;
using SampleApp.Models;
using System.Collections.Generic;

namespace SampleApp.Queries
{
    public class GetSampleModelListQuery : IRequest<List<SampleModel>>
    {
    }
}
