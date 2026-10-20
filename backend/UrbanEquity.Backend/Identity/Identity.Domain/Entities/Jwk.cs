using System.Text.Json.Serialization;

namespace Identity.Domain.Entities
{
	public class Jwk
	{
		[JsonPropertyName("kty")]
		public string Kty { get; }
		[JsonPropertyName("use")]
		public string Use { get; }
		[JsonPropertyName("kid")]
		public string Kid { get; }
		[JsonPropertyName("x5t")]
		public string X5t { get; }
		[JsonPropertyName("e")]
		public string E { get; }
		[JsonPropertyName("n")]
		public string N { get; }
	}
}