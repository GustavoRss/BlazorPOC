using Newtonsoft.Json;

namespace BlazorPOC.Models
{
    public class Usuario
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }
    }
}
