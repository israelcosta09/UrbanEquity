using Identity.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Application.Controllers
{
	[ApiController]
	public class JwksController : ControllerBase
	{
		[HttpGet(".well-known/jwks.json")]
		public async Task<Jwks> HandleGetJwks()
		{
			throw new NotImplementedException();
		}
	}
}