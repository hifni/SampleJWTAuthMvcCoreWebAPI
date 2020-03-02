using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleJWTAuthMvcCoreWebAPI.Models
{
    public class ResponseModel
    {
        public string Message { set; get; }
        public string AdditionalMessage { get; set; }
        public bool Status { set; get; }
        public object Data { set; get; }
    }
}
