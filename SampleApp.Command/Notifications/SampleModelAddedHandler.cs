using SampleApp.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Notifications
{
    public class SampleModelAddedHandler : MediatR.INotificationHandler<SampleObjectAdded>
    {
        private readonly IReadonlyRepository _readonlyRepository;

        public SampleModelAddedHandler(IReadonlyRepository readonlyRepository)
        {
            _readonlyRepository = readonlyRepository;
        }

        public async Task Handle(SampleObjectAdded notification, CancellationToken cancellationToken)
        {
            _readonlyRepository.PushNew(notification.SampleModel);
        }
    }
}
