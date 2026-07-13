using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Polymarket.Net.Objects.Models
{
    internal record PolymarketPriceHistoryWrapper
    {
        /// <summary>
        /// ["<c>history</c>"] History
        /// </summary>
        [JsonPropertyName("history")]
        public PolymarketPriceHistory[] History { get; set; } = [];
    }

    /// <summary>
    /// Price histories
    /// </summary>
    public record PolymarketPriceHistories
    {
        /// <summary>
        /// ["<c>history</c>"] History
        /// </summary>
        [JsonPropertyName("history")]
        public Dictionary<string, PolymarketPriceHistory[]> History { get; set; } = new();
    }


    /// <summary>
    /// Price history
    /// </summary>
    public record PolymarketPriceHistory
    {
        /// <summary>
        /// ["<c>t</c>"] Timestamp
        /// </summary>
        [JsonPropertyName("t")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>p</c>"] Price
        /// </summary>
        [JsonPropertyName("p")]
        public decimal Price { get; set; }
    }


}
