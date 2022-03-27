using api.Domain.Models;
using api.Services.Commands;
using api.Services.Dtos;
using api.Services.Queries;
using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("pirates")]
public class PiratesController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public PiratesController(IMediator mediator, IMapper mapper)
    {
        (_mediator, _mapper) = (mediator, mapper);
    }
 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("GetAll")]
    public async Task<ActionResult<List<GetAllPiratesResponseDto>>> GetAll()
    {
        try
        {
            var response = await _mediator.Send(new GetAllPiratesQuery());
            return response.Adapt<List<GetAllPiratesResponseDto>>();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
 
 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("createPirate")]
    public async Task<ActionResult<CreatePirateResponseDto>> Create(CreatePirateResponseDto createPirate)
    {
        try
        {
            var pirate = _mapper.Map<Pirate>(createPirate);
            var response = await _mediator.Send(new CreatePirateCommand
            {
                Pirate = pirate
            });
 
            return _mapper.Map<CreatePirateResponseDto>(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
 
}