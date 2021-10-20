using MediatR;
using SampleApp.Models;

namespace SampleApp.Commands
{
    public class UpdateSampleModelCommand : IRequest<Unit>
    {
        public SampleModel SampleModel { get; }

        public UpdateSampleModelCommand(SampleModel sampleModel)
        {
            SampleModel = sampleModel;
        }
    }
}
