using InsuranceProposalManagement.API.Models;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace InsuranceProposalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion(ApiVersions.V1)]
    public class InsuraceProposalController(IMediator mediator) : ControllerBase
    {

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetInsuraceProposalByIdQuery>> GetInsuraceProposalById(int id)
        {
            var getProposal = new GetProposalByIdQuery { ID = id };
            var result = await mediator.Send(getProposal);
            
            return Ok(result);
        }


        [HttpGet("Get/ListProposal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<GetInsuraceProposalByIdQuery>>> GetistIncuraceProposal()
        {
            var result = await mediator.Send(new GetListProposalQuery());

            return Ok(result);
        }


        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsuraceProposalResult>>  CreateProposal([FromBody] CreateProposalCommand request)
        {
            var result = await mediator.Send(request);
            var resultStatus = result;

            return Ok(resultStatus.ResultTypeStatus.ToString());
        }


        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InsuraceProposalResult>> ChangestatusProposal([FromBody] ChangeProposalCommand request)
        {
            var result = await mediator.Send(request);

            if(result != null)
                return Ok(result.ResultTypeStatus.ToString());

            return NotFound(result);
        }
    }
}
