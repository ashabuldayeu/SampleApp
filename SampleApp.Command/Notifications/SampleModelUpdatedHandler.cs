using MediatR;
using SampleApp.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Notifications
{
    public class SampleModelUpdatedHandler : INotificationHandler<SampleModelUpdated>
    {
        private readonly IReadonlyRepository _readonlyRepository;

        public SampleModelUpdatedHandler(IReadonlyRepository readonlyRepository)
        {
            _readonlyRepository = readonlyRepository;
        }

        public async Task Handle(SampleModelUpdated notification, CancellationToken cancellationToken)
        {
            _readonlyRepository.PushToUpdate(notification.SampleModel);
        }
    }
}
