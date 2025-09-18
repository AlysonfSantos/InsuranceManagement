using InsuranceContractManagement.Application.Command;
using InsuranceContractManagement.Application.Queries;
using InsuranceContractManagement.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;



namespace InsuranceContractManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
[ApiVersion(ApiVersions.V1)]
public class InsuranceContractController(IMediator mediator) : ControllerBase
{

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<InsuranceContractResult>> GetInsuraceContractById(int id)
    {
        var getProposal = new GetInsuranceContractQuery { Id = id };
        var result = await mediator.Send(getProposal);

        if(result.Data is null)
            return NotFound(result);

        return Ok(result);
    }
}
