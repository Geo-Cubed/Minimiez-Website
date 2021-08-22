using MediatR;

namespace GeoCubed.Minimiez.Application.Features.Welcome.Queries.WelcomeMessage
{
    public record WelcomeMessageQuery() : IRequest<string>;
}