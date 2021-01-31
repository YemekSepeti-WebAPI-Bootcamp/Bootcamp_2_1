using System;
using System.ComponentModel.DataAnnotations;

namespace model_dto_validation.RequestModel
{
    public class DailyForecastRequest
    {
        [Required(ErrorMessage = "Id boş geçilemez")]
        public int Id { get; set; }
        [StringLength(10, ErrorMessage = "Client ID maksimum 10 karaketer olabilf")]
        public string ClientId { get; set; }
        public DateTime Date { get; set; }

        public int ForecastType { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }
    }
}
