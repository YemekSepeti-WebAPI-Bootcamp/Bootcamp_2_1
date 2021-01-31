using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using model_dto_validation.Data.Context;
using model_dto_validation.Filters;
using model_dto_validation.Mapping;
using model_dto_validation.RequestModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace model_dto_validation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForecastController : ControllerBase
    {

        private DbContextOptions<DatabaseContext> option;

        public ForecastController()
        {
            option = new DbContextOptionsBuilder<DatabaseContext>()
                   .UseInMemoryDatabase(databaseName: "TestDatabase")
                   .Options;

        }


        [HttpGet]
        public IActionResult Get()
        {
            List<DailyForecastModel> result = new List<DailyForecastModel>();

            using (DatabaseContext dbContext = new DatabaseContext(option))
            {
                var entityList = dbContext.DailyForecasts.ToList();
                result = entityList.ToDailyForecastResponse();
            }

            return Ok(result);
        }


        [HttpPost]
        [ValidationActionModel]
        public IActionResult Post([FromBody] DailyForecastRequest request)
        {
            #region validation1
            List<string> validations = new List<string>();

            if (request.ClientId == string.Empty)
            {
                validations.Add("client id boş geçilemez");
            }

            if (request.TemperatureC <= -50)
            {
                validations.Add("Geçersiz sıcaklık değeri");
            }

            if (validations.Any())
                return BadRequest(validations);

            #endregion validation1

            #region validation2

            var request2 = JsonConvert.DeserializeObject<DailyForecastRequestV2>(JsonConvert.SerializeObject(request));

            var validate2_0 = request2.Validate();
            if (validate2_0.Item1)
                return BadRequest(validate2_0.Item2);

            var validate2_1 = request2.Validate2();
            if (!validate2_1.isValid)
                return BadRequest(validate2_1.validationErrors);


            #endregion validation2

            #region Validation3

            var request3 = JsonConvert.DeserializeObject<DailyForecastRequestV3>(JsonConvert.SerializeObject(request));

            var validation3 = request3.Validation();
            if (!validation3.isValid)
                return BadRequest(validation3.validationErrors);

            #endregion Validation3

            #region Validation4

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            #endregion Validation4

            #region Validation5

            var request5 = JsonConvert.DeserializeObject<DailyForecastRequestV5>(JsonConvert.SerializeObject(request));

            var context5 = new ValidationContext(request5);
            var validationResult5 = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(request5, context5, validationResult5, true);
            if (!isValid)
                return BadRequest(validationResult5);


            #endregion Validation5

            #region Valdiation6
            var request6 = JsonConvert.DeserializeObject<DailyForecastRequestV6>(JsonConvert.SerializeObject(request));

            var context6 = new ValidationContext(request6);
            var validationResult6 = new List<ValidationResult>();

            bool isValid6 = Validator.TryValidateObject(request6, context6, validationResult6, true);
            if (!isValid6)
                return BadRequest(validationResult6);


            #endregion Valdiation6



            return Ok();

        }

    }
}
