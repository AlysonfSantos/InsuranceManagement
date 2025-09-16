using InsuranceProposalManagement.API.Models;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Application.Handler;
using InsuranceProposalManagement.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InsuranceProposalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion(ApiVersions.V1)]
    public class InsuraceProposalController(IMediator mediator) : ControllerBase
    {

        [HttpPost("meuovo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetInsuraceProposalByIdQuery>> meuovo(GetProposalCommand request)
        {
            var result = await mediator.Send(request);
            
            return Ok(result);

        }

        // GET api/<InsuraceProposalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InsuraceProposalController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Post([FromBody] CreateProposalCommand value)
        {
            var result = await mediator.Send(value);
            var resultStatus = result;

            return Ok(resultStatus.ResultTypeStatus.ToString());
        }

        // PUT api/<InsuraceProposalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InsuraceProposalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
