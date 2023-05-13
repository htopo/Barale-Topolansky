using ArenaGestor.API.Filters;
using ArenaGestor.APIContracts;
using ArenaGestor.APIContracts.Snacks;
using ArenaGestor.BusinessInterface;
using ArenaGestor.Domain;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArenaGestor.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ExceptionFilter]
    public class SnacksController : ControllerBase, ISnacksAppService
    {
        private readonly ISnacksService snacksService;
        private readonly IMapper mapper;

        public SnacksController(ISnacksService snacksService, IMapper mapper)
        {
            this.snacksService = snacksService;
            this.mapper = mapper;
        }

        //[AuthorizationFilter(RoleCode.Administrador)]
        [HttpPost]
        public IActionResult PostSnack([FromBody] SnackInsertSnackDto insertSnack)
        {
            var snack = mapper.Map<Snack>(insertSnack);
            var result = snacksService.InsertSnack(snack);
            var resultDto = mapper.Map<SnackResultSnackDto>(result);
            return Created("/snacks",resultDto);
        }

        //[AuthorizationFilter(RoleCode.Administrador)]
        [HttpDelete("{snackName}")]
        public IActionResult DeleteSnack([FromRoute] string snackName)
        {
            snacksService.DeleteSnack(snackName);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetSnacks()
        {
            var snacks = snacksService.GetAllSnacks();
            return Ok(snacks);
        }
    }
}
