using MediatR;
using System;

namespace CQRS.Events
{
    public record CustomerCreatedEvent(string FirstName,
        string LastName,
        DateTime RegistrationDate) : INotification;
}