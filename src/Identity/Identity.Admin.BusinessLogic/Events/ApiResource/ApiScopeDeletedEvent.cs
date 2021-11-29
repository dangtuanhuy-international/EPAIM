using Identity.Admin.BusinessLogic.Dtos.Configuration;
using Skoruba.AuditLogging.Events;

namespace Identity.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiScopeDeletedEvent : AuditEvent
    {
        public ApiScopesDto ApiScope { get; set; }

        public ApiScopeDeletedEvent(ApiScopesDto apiScope)
        {
            ApiScope = apiScope;
        }
    }
}