using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Queue
{
    public class Publisher : MediatR.IPublisher
    {
        public Task Publish(object notification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
        {
            throw new NotImplementedException();
        }
    }
}
