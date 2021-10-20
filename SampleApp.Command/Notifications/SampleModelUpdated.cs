using MediatR;
using SampleApp.Models;

namespace SampleApp.Notifications
{
    public class SampleModelUpdated : INotification
    {
        public SampleModel SampleModel { get; }

        public SampleModelUpdated(SampleModel sampleModel)
        {
            SampleModel = sampleModel;
        }
    }
}
