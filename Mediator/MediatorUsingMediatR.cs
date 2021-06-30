using MediatR;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorUsingMediatR
{
    public class PongResponse
    {
        public DateTime Timestamp { get; set; }

        public PongResponse(DateTime timestamp)
        {
            Timestamp = timestamp;
        }
    }

    public class PingCommand : IRequest<PongResponse>
    {
        public PingCommandHandler PingCommandHandler
        {
            get => default;
            set
            {
            }
        }
    }

    public class PingCommandHandler : IRequestHandler<PingCommand, PongResponse>
    {
        public PongResponse PongResponse
        {
            get => default;
            set
            {
            }
        }

        public async Task<PongResponse> Handle(PingCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new PongResponse(DateTime.Now)).ConfigureAwait(false);
        }
    }
}