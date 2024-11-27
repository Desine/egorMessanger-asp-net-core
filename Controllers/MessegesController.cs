using egorMessenger.Data;
using egorMessenger.Dtos.Messege;
using egorMessenger.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace egorMessenger.Controllers;

[Route("stock")]
[ApiController]
public class MessageController : ControllerBase
{

    private readonly ApplicationDBContext _context;
    public MessageController(ApplicationDBContext context)
    {
        _context = context;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var messages = _context.Messages.ToList()
        .Select(s => s.ToMessegeDto());

        return Ok(messages);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var message = _context.Messages.Find(id);

        if (message == null) return NotFound();

        return Ok(message.ToMessegeDto());
    }
    [HttpPost]
    public IActionResult Post([FromBody] PostMessageRequestDto messageDto)
    {
        var messageModel = messageDto.ToMessageFromPostDto();
        _context.Messages.Add(messageModel);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new { id = messageModel.Id }, messageModel.ToMessegeDto());
    }
    [HttpDelete]
    public IActionResult DeleteAll()
    {
        var messages = _context.Messages.ToList();
        _context.Messages.RemoveRange(messages);
        _context.SaveChanges();
        return Ok();
    }

}