using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ValidacaoComExceptionFilter;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is BusinessException)
        {
            context.Result = new BadRequestObjectResult($"ExceptionFilter: {context.Exception.Message}");
            context.ExceptionHandled = true;
        }
    }
}
