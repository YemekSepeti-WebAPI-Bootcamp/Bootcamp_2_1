using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace model_dto_validation.RequestModel
{
    public class DailyForecastRequestV5 
    {
        public int Id { get; set; }

        public string ClientId { get; set; }
        public DateTime Date { get; set; }

        public int ForecastType { get; set; }

        [Range(-10, 45, ErrorMessage = "Sıcaklık belirtilen aralıkta değil.")]
        public int TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
