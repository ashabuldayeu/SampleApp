using SampleApp.Models;

namespace SampleApp.Commands
{
    public class AddSampleModelCommand : MediatR.IRequest<int>
    {
        public AddSampleModelCommand(SampleModel sampleModel)
        {
            SampleModel = sampleModel;
        }

        public SampleModel SampleModel { get; set; }
    }
}
