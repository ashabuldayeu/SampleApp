using MediatR;
using SampleApp.Notifications;
using SampleApp.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Commands.Handlers
{
    public class UpdateSampleModelCommandHandler : IRequestHandler<UpdateSampleModelCommand, Unit>
    {
        private readonly IWriteRepository _writeRepository;

        public UpdateSampleModelCommandHandler(IWriteRepository writeRepository, IMediator mediator)
        {
            _writeRepository = writeRepository;
            _mediator = mediator;
        }

        private readonly IMediator _mediator;

        public async Task<Unit> Handle(UpdateSampleModelCommand request, CancellationToken cancellationToken)
        {
            _writeRepository.Update(request.SampleModel);

            await _mediator.Publish(new SampleModelUpdated(request.SampleModel));

            return Unit.Value;
        }
    }
}
