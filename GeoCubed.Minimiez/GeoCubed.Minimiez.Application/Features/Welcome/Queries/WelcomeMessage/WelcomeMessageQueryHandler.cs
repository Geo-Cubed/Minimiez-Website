using GeoCubed.Minimiez.Application.Common;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GeoCubed.Minimiez.Application.Features.Welcome.Queries.WelcomeMessage
{
    public class WelcomeMessageQueryHandler : IRequestHandler<WelcomeMessageQuery, string>
    {
        public WelcomeMessageQueryHandler()
        {
        }

        public Task<string> Handle(WelcomeMessageQuery request, CancellationToken cancellationToken)
        {
            var msg = ResourceHelper.WelcomeMessage;
            return Task.FromResult(msg);
        }
    }
}
