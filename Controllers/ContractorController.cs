using Microsoft.AspNetCore.Mvc;
using DotNetApi.Models;
using System.Collections.Generic;
namespace DotNetApi.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorController:ControllerBase {
    [HttpGet]
    public IEnumerable<Contractor> Get()=>new List<Contractor>{new Contractor{Id=1,Name="John Doe"}};
  }
}