using SampleApp.Models;

namespace SampleApp.Notifications
{
    public class SampleObjectAdded : MediatR.INotification
    {
        public SampleObjectAdded(SampleModel sampleModel)
        {
            SampleModel = sampleModel;
        }

        public SampleModel SampleModel { get; set; }
    }
}
