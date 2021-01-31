using model_dto_validation.Validation;
using System;

namespace model_dto_validation.RequestModel
{
    public class DailyForecastRequestV6
    {
        public int Id { get; set; }

        public string ClientId { get; set; }
        public DateTime Date { get; set; }

        public int ForecastType { get; set; }
        [Temperature(-5, ErrorMessage ="Sıcaklık maksimum -5 olabilri")]
        public int TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
