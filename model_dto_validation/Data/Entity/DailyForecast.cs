using System;

namespace model_dto_validation.Data.Entity
{
    public class DailyForecast
    {
        public int Id { get; set; }
        public int ForecastType { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
}
