using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListenerController : ControllerBase
    {
        private readonly IAccountServices _accountServices;

        public ListenerController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        // GET: api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountServices.GetAccounts());
        }

    }
}
