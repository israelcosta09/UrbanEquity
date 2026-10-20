using Identity.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Application.Controllers
{

	[ApiController]
	public class OpenIdConfigurationController : ControllerBase
	{
		[HttpGet(".well-known/openid-configuration")]
		public async Task<OpenIdConfiguration> HandleGetOne()
		{
			throw new NotImplementedException();
		}
	}
}