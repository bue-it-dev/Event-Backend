using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Event.Controllers.Config
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState.GetErrorMessages();
            var response =  errors;

            return new BadRequestObjectResult(response);
        }
    }
}
