using MediatR;
using profileEndpoint.Domain.Models.Dto;

namespace profileEndpoint.Application.Queries.GetMe;

public class GetMeQuery : IRequest<ProfileOutput>
{

}
