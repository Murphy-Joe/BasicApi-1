using BasicApi.Controllers;

namespace BasicApi.Services;

public interface ILookupOnCallDevelopers
{
    Task<OnCallDeveloperInformation> GetOnCallDeveloperAsync();
}
