using MediatR;
using SampleApp.Notifications;
using SampleApp.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.Commands.Handlers
{
    public class AddSampleModelCommandHandler : IRequestHandler<AddSampleModelCommand, int>
    {
        private readonly IWriteRepository _writeRepository;
        private readonly IMediator _mediator;

        public AddSampleModelCommandHandler(IWriteRepository writeRepository, IMediator mediator)
        {
            _writeRepository = writeRepository;
            _mediator = mediator;
        }

        public async Task<int> Handle(AddSampleModelCommand request, CancellationToken cancellationToken)
        {
            var id = _writeRepository.Add(request.SampleModel);

            request.SampleModel.Id = id;

            // put here notification request
            await _mediator.Publish(new SampleObjectAdded(request.SampleModel));

            return id;
        }
    }
}
