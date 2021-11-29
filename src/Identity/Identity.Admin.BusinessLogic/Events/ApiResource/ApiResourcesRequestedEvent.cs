using Identity.Admin.BusinessLogic.Dtos.Configuration;
using Skoruba.AuditLogging.Events;

namespace Identity.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiResourcesRequestedEvent : AuditEvent
    {
        public ApiResourcesRequestedEvent(ApiResourcesDto apiResources)
        {
            ApiResources = apiResources;
        }

        public ApiResourcesDto ApiResources { get; set; }
    }
}