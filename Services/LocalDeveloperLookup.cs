using BasicApi.Controllers;

namespace BasicApi.Services
{
    public class LocalDeveloperLookup : ILookupOnCallDevelopers
    {
        public async Task<OnCallDeveloperInformation> GetOnCallDeveloperAsync()
        {
            await Task.Delay(3000);
            return new OnCallDeveloperInformation { 
                OnCallDeveloperEmail = "Bob@aol.com", 
                OnCallDeveloperName = "Robert Smith" };
        }
    }
}
