using model_dto_validation.Data.Entity;
using model_dto_validation.Enums;
using System.Collections.Generic;

namespace model_dto_validation.Mapping
{
    public static class MappingExtension
    {

        public static List<DailyForecastModel> ToDailyForecastResponse(this List<DailyForecast> forecasts)
        {
            List<DailyForecastModel> result = new List<DailyForecastModel>();

            for (int i = 0; i < forecasts.Count; i++)
            {
                result.Add(new DailyForecastModel
                {
                    Id = forecasts[i].Id,
                    Date = forecasts[i].Date,
                    ForecastType = (ForecastType)forecasts[i].ForecastType,
                    Summary = forecasts[i].Summary,
                    TemperatureC = forecasts[i].TemperatureC,
                    TemperatureF = 30 + (forecasts[i].TemperatureC * 3)
                });
            }

            return result;
        }
    }
}
