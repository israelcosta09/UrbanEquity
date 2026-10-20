using Identity.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Application.Controllers
{

	[ApiController]
	public class TokenController : ControllerBase
	{
		[HttpPost("oauth2/token")]
		public async Task<Token> HandlePostToken(
				[FromForm(Name = "grant_type")] string grantType,
				[FromForm(Name = "client_id")] string clientId,
				[FromForm(Name = "code")] string code,
				[FromForm(Name = "redirect_uri")] string redirecturi,
				[FromForm(Name = "code_verifier")] string codeVerifier)
		{
			throw new NotImplementedException();
		}
	}
}