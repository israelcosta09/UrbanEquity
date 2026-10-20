using System.Text.Json.Serialization;

namespace Identity.Domain.Entities
{
	public class Jwks
	{
		[JsonPropertyName("keys")]
		public IEnumerable<Jwk> Keys { get; }
	}
}