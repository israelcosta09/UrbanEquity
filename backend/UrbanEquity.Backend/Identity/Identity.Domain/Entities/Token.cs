using System.Text.Json.Serialization;

namespace Identity.Domain.Entities
{
	public class Token
	{
		[JsonPropertyName("access_token")]
		public string AccessToken { get; }
		[JsonPropertyName("token_type")]
		public string TokenType { get; }
		[JsonPropertyName("expires_in")]
		public int ExpiresIn { get; }
		[JsonPropertyName("refresh_token")]
		public string RefreshToken { get; }
		[JsonPropertyName("id_token")]
		public string IdToken { get; }
	}
}