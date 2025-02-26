using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly CreateAboutCommandHandler _createAboutCommandHandler;
        private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;
        private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;
        private readonly GetAboutQueryHandler      _getAboutQueryHandler;
        private readonly GetAboutByIdQueryHandler  _getAboutByIdQueryHandler;

        public AboutsController(CreateAboutCommandHandler createAboutCommandHandler, UpdateAboutCommandHandler updateAboutCommandHandler, RemoveAboutCommandHandler removeAboutCommandHandler, GetAboutQueryHandler getAboutQueryHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler)
        {
            _createAboutCommandHandler = createAboutCommandHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
            _removeAboutCommandHandler = removeAboutCommandHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand createAboutCommand)
        {
            await _createAboutCommandHandler.Handle(createAboutCommand);
            return Ok("Hakkımda Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("Hakkımda Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand updateAboutCommand)
        {
            await _updateAboutCommandHandler.Handle(updateAboutCommand);
            return Ok("Hakkımda Bilgisi Güncellendi");
        }
    }
}
