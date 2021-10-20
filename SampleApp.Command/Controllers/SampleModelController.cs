using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Commands;
using SampleApp.Models;
using SampleApp.Queries;
using System.Threading.Tasks;

namespace SampleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleModelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SampleModelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> Put(SampleModel sampleModel)
        {
            await _mediator.Send(new UpdateSampleModelCommand(sampleModel));

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SampleModel sampleModel)
        {
            var id = await _mediator.Send(new AddSampleModelCommand(sampleModel));
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var results = await _mediator.Send(new GetSampleModelListQuery());
            return Ok(results);
        }
    }
}
