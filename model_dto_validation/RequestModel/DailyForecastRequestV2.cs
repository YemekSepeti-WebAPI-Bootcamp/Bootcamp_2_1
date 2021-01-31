using System;
using System.Collections.Generic;

namespace model_dto_validation.RequestModel
{
    public class DailyForecastRequestV2
    {
        public int Id { get; set; }

        public string ClientId { get; set; }
        public DateTime Date { get; set; }

        public int ForecastType { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public Tuple<bool, List<string>> Validate()
        {

            List<string> validateList = new List<string>();
            if (ClientId.Trim() == string.Empty)
                validateList.Add("client Id Boş geçilemez");


            if (TemperatureC < -50)
                validateList.Add("geçersiz sıcaklık değeri");

            return new Tuple<bool, List<string>>(validateList.Count <= 0, validateList);
        }


        public (bool isValid, List<string> validationErrors) Validate2()
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
