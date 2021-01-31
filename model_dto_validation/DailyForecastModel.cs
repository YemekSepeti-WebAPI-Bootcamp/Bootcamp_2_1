using model_dto_validation.Enums;
using System;

namespace model_dto_validation
{
    public class DailyForecastModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public ForecastType ForecastType { get; set; }

        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }

        public string Summary { get; set; }

    }
}
