using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers.Errors;

namespace API.Errors
{
    public class ApiValidationErrorResponse: ApiResponse
    {
        public ApiValidationErrorResponse() : base(400)
        {
        }
        public IEnumerable<string>Errors{get;set;}
    }
}