namespace EngagementApi.Models
{
    public class TemperatureItem
    {
        public DateTime Date { get; set; }

        public int Temperature { get; set; }

        public string? Place { get; set; }
    }
}