using AutoMapper;
using BasicApi.Controllers;
using BasicApi.Data;

namespace BasicApi.AutomapperProfiles;

public class AgentsProfile : Profile
{
    public AgentsProfile()
    {
        // (Agent => AgentResponseItem)
       CreateMap<Agent, AgentResponseItem>();
    }
}
