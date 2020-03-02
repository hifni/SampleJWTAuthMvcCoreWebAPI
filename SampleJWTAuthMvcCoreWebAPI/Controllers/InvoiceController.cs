using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleJWTAuthMvcCoreWebAPI.Models;

namespace SampleJWTAuthMvcCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        InvoiceContext ctx = new InvoiceContext();
        Models.ResponseModel responseModel = new Models.ResponseModel();

        public ActionResult<ResponseModel> Get()
        {
            responseModel = new Models.ResponseModel()
            {
                Message = "Ok",
                Status = true,
                Data = ctx.Get()
            };

            return responseModel;
        }
    }
}