using System;
using System.Collections.Generic;

namespace model_dto_validation.RequestModel
{
    public interface IRequestModel
    {
        (bool isValid, List<string> validationErrors) Validation();
    }


    public class DailyForecastRequestV3 : IRequestModel
    {
        public int Id { get; set; }

        public string ClientId { get; set; }
        public DateTime Date { get; set; }

        public int ForecastType { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public (bool isValid, List<string> validationErrors) Validation()
        {
            List<string> validateList = new List<string>();
            if (ClientId.Trim() == string.Empty)
                validateList.Add("client Id Boş geçilemez");


            if (TemperatureC < -50)
                validateList.Add("geçersiz sıcaklık değeri");

            return (validateList.Count <= 0, validateList);

        }
    }





}
