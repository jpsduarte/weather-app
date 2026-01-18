using System.Text.Json.Serialization;

namespace WeatherApp.Models;

public class OpenMeteoResponse
{
    [JsonPropertyName("daily")]
    public DailyData Daily { get; set; } = default!;
}

public class DailyData
{
    [JsonPropertyName("time")]
    public List<string> Time { get; set; } = new();

    [JsonPropertyName("temperature_2m_min")]
    public List<double> Temperature_2m_Min { get; set; } = new();

    [JsonPropertyName("temperature_2m_max")]
    public List<double> Temperature_2m_Max { get; set; } = new();
}
