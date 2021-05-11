using API.Dto;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepositController : ControllerBase
    {

        public readonly IDepositRepository _depositRepository;

        public DepositController(IDepositRepository depositRepository)
        {
            _depositRepository = depositRepository;
        }

        [HttpPost]
        public IActionResult DepositMoney([FromBody] DepositDto payload)
        {
            int id = _depositRepository.DepositMoney(payload);
            return Ok(id);
        }


        [HttpGet("checkBalance")]
        public IActionResult CheckBalance()
        {
            return Ok();
        }
    }
}
