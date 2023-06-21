using Backend.Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Backend.Filters;

public class ExceptionFilter : IExceptionFilter
{
    private const int statusCode = 500;

    public void OnException(ExceptionContext context)
    {
        var error = new ErrorDto
        {
            StatusCode = statusCode.ToString(),
            Message = context.Exception.Message
        };

        context.Result = new JsonResult(error) { StatusCode = statusCode };
    }
}