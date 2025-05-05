using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiziFilmUygulamas.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public float AvgRate { get; set; }

        // your Java field is "private List<RateEntity> rate;"
        // so we match it as a collection of Rate objects:
        [JsonPropertyName("rate")]
        public List<Rating> Ratings { get; set; }

        // for the image blob:
        public byte[] Image { get; set; }
    }
}
