using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleJWTAuthMvcCoreWebAPI.Models;

namespace SampleJWTAuthMvcCoreWebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        Models.ResponseModel responseModel = new Models.ResponseModel();

        // GET api/values
        [HttpGet]
        public ActionResult<ResponseModel> Get()
        {
            responseModel = new Models.ResponseModel()
            {
                Message = "Ok",
                AdditionalMessage = "If you see this, which essentially means your request was responded",
                Status = true,
                Data = new string[] { "value1", "value2" }
            };

            return responseModel;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ResponseModel> Get(int id)
        {
            responseModel = new Models.ResponseModel()
            {
                Message = "Ok",
                Status = true,
                Data = "value"
            };

            return responseModel;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
