using Identity.Admin.BusinessLogic.Dtos.Configuration;
using Skoruba.AuditLogging.Events;

namespace Identity.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiScopeRequestedEvent : AuditEvent
    {
        public ApiScopesDto ApiScopes { get; set; }

        public ApiScopeRequestedEvent(ApiScopesDto apiScopes)
        {
            ApiScopes = apiScopes;
        }
    }
}