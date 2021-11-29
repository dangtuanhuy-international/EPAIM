using Identity.Admin.BusinessLogic.Dtos.Configuration;
using Skoruba.AuditLogging.Events;

namespace Identity.Admin.BusinessLogic.Events.Client
{
    public class ClientPropertyDeletedEvent : AuditEvent
    {
        public ClientPropertiesDto ClientProperty { get; set; }

        public ClientPropertyDeletedEvent(ClientPropertiesDto clientProperty)
        {
            ClientProperty = clientProperty;
        }
    }
}