using Newtonsoft.Json;

namespace AnimalInfo
{
    public class AnimalViewModel
    {
        public string Name { get; set; }
        public string Population { get; set; }
        public string ScientificName { get; set; }
        [JsonProperty("Height")]
        public string AnimalHeight { get; set; }
        public string Weight { get; set; }
        public string Length { get; set; }
        public string Habitats { get; set; }
        public string Origin { get; set; }
    }
}