using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Events
{
    public class CustomerCreatedEmailSenderHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            // IMessageSender.Send($"Welcome {notification.FirstName} {notification.LastName} !");
            return Task.CompletedTask;
        }
    }
}