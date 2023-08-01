using Microsoft.AspNetCore.Mvc;
using web_server.models;

namespace web_server.controllers;

[ApiController]
[Route("api/[controller]")]
public class DelicacyController
{
    [HttpGet("get_delicacy_range")]
    public ActionResult<IList<Delicacy>> GetALlDelicacy(IRangeSelector range_selector)
    {
        throw new NotImplementedException();
    }
}