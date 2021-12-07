using AutoMapper;
using BasicApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using AutoMapper.QueryableExtensions;

namespace BasicApi.Controllers;

public class AgentsController : ControllerBase
{

    private readonly BasicDataContext _context;
    private readonly IMapper _mapper;
    private readonly MapperConfiguration _config;

    public AgentsController(BasicDataContext context, IMapper mapper, MapperConfiguration config)
    {
        _context = context;
        _mapper = mapper;
        _config = config;
    }

    [HttpGet("/agents")]
    public async Task<ActionResult<GetAgentsResponse>> GetAllAgents()
    {

        var response = new GetAgentsResponse();
        response.Agents = await _context.Agents!
             .Where(a => a.Retired == false)
             .ProjectTo<AgentResponseItem>(_config)
             .ToListAsync();
        return Ok(response); 


    }
}


public class GetAgentsResponse
{
    [Required]
    public List<AgentResponseItem> Agents { get; set; } = new List<AgentResponseItem>();
}

public class AgentResponseItem
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
}
