using Microsoft.AspNetCore.Mvc;

namespace Identity.Application.Controllers
{

    [ApiController]
	public class AuthorizationController : ControllerBase
	{
		[HttpGet("oauth2/authorize")]
		public async Task<IActionResult> HandleGetAuthorize(
				[FromQuery(Name = "response_type")] string responseType,
				[FromQuery(Name = "client_id")] string clientId,
				[FromQuery(Name = "redirect_uri")] string redirectUri,
				[FromQuery(Name = "scope")] string scope,
				[FromQuery(Name = "state")] string state,
				[FromQuery(Name = "nonce")] string? nonce,
				[FromQuery(Name = "code_challenge")] string codeChallenge,
				[FromQuery(Name = "code_challenge_method")] string codeChallengeMethod)
		{
			throw new NotImplementedException();
		}
	}
}