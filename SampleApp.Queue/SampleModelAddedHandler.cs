using System;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Queue
{
    public class SampleModelAddedHandler : MediatR.INotificationHandler<SampleObjectAdded>
    {
        public Task Handle(SampleObjectAdded notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
