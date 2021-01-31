using model_dto_validation.Enums;
using model_dto_validation.RequestModel;
using System.ComponentModel.DataAnnotations;

namespace model_dto_validation.Validation
{
    public class Temperature : ValidationAttribute
    {
        private int _maxTemperature;

        public Temperature(int maxTemperature)
        {
            _maxTemperature = maxTemperature;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DailyForecastRequestV6 forecastModel = (DailyForecastRequestV6)validationContext.ObjectInstance;

            if(forecastModel.ForecastType == (int)ForecastType.Weather && forecastModel.Summary == "Snowy")
            {
                if(forecastModel.TemperatureC > _maxTemperature)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.MemberName));
                }
            }

            return ValidationResult.Success;
        }

        //public override bool IsValid(object value)
        //{
        //    return ((int)value) < _maxTemperature;
        //}

    }
}
