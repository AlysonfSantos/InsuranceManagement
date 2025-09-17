using Azure.Core;
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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetInsuraceProposalByIdQuery>> GetInsuraceProposalById(int id)
        {
            var getProposal = new GetProposalByIdCommand { ID = id };
            var result = await mediator.Send(getProposal);
            
            return Ok(result);
        }

        // GET api/<InsuraceProposalController>/5
        [HttpGet("Get/ListProposal")]
        public async Task<ActionResult<IEnumerable<GetInsuraceProposalByIdQuery>>> GetistIncuraceProposal()
        {
            var result = await mediator.Send(new GetListProposalCommand());

            return Ok(result);
        }

        // POST api/<InsuraceProposalController>
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<InsuraceProposalResult>>  CreateProposal([FromBody] CreateProposalCommand request)
        {
            var result = await mediator.Send(request);
            var resultStatus = result;

            return Ok(resultStatus.ResultTypeStatus.ToString());
        }

        // PUT api/<InsuraceProposalController>/5
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsuraceProposalResult>> ChangestatusProposal([FromBody] ChangeProposalCommand request)
        {
            var result = await mediator.Send(request);
            //var resultStatus = result?.ResultTypeStatus;
            
            if(!result.IsValue)
                return NotFound(result);

            return Ok(result.ResultTypeStatus.ToString());
        }

        // DELETE api/<InsuraceProposalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
