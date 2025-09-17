using InsuranceContractManagement.Application.Command;
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
    public async Task<ActionResult<InsuraceContractResult>> GetInsuraceContractById(int id)
    {
        var getProposal = new GetInsuranceContractCommand { Id = id };
        var result = await mediator.Send(getProposal);

        return Ok(result);
    }

    // GET api/<InsuranceContractController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<InsuranceContractController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<InsuranceContractController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<InsuranceContractController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
