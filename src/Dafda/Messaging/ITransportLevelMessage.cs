using System;

namespace Dafda.Messaging
{
    public interface ITransportLevelMessage
    {
        string MessageId { get; }
        string Type { get; }
        string CorrelationId { get; }
        T ReadDataAs<T>() where T : class, new();
        object ReadDataAs(Type messageInstanceType);
    }
}