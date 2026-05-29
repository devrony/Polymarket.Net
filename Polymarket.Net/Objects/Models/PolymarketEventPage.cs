using System.Text.Json.Serialization;

namespace Polymarket.Net.Objects.Models
{
    /// <summary>
    /// Events page
    /// </summary>
    public record PolymarketEventPage
    {
        /// <summary>
        /// ["<c>events</c>"] Events
        /// </summary>
        [JsonPropertyName("events")]
        public PolymarketEvent[] Events { get; set; } = [];

        /// <summary>
        /// ["<c>next_cursor</c>"] Pagination cursor
        /// </summary>
        [JsonPropertyName("next_cursor")]
        public string? NextPageCursor { get; set; }
    }
}
