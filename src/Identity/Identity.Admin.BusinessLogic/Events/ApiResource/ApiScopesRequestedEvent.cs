using Identity.Admin.BusinessLogic.Dtos.Configuration;
using Skoruba.AuditLogging.Events;

namespace Identity.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiScopesRequestedEvent : AuditEvent
    {
        public ApiScopesDto ApiScope { get; set; }

        public ApiScopesRequestedEvent(ApiScopesDto apiScope)
        {
            ApiScope = apiScope;
        }
    }
}