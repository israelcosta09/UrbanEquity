using System.Text.Json.Serialization;

namespace Identity.Domain.Entities
{
	public class OpenIdConfiguration
	{
		[JsonPropertyName("issuer")]
		public string Issuer { get; }
		[JsonPropertyName("authorization_endpoint")]
		public string AuthorizationEndpoint { get; }
		[JsonPropertyName("jwks_uri")]
		public string JwksUri { get; }
		[JsonPropertyName("response_types_supported")]
		public IEnumerable<string> ResponseTypesSupported { get; }
		[JsonPropertyName("subject_types_supported")]
		public IEnumerable<string> SubjectTypesSupported { get; }
		[JsonPropertyName("id_token_signing_alg_values_supported")]
		public IEnumerable<string> IdTokenSigningAlgValuesSupported { get; }
	}
}