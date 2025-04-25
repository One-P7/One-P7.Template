using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ThreeLayer.Common.ViewModels;

namespace ThreeLayer.Common.ActionFilters;

/// <summary>
/// 驗證方法參數的 Attribute
/// </summary>
/// <param name="validatorType">用於驗證參數的驗證器類型</param>
/// <param name="parameterName">要驗證的方法參數名稱</param>
public class ParameterValidatorAttribute(Type validatorType, string parameterName = null) : ActionFilterAttribute
{
    private readonly string _parameterName = parameterName;

    private readonly Type _validatorType = validatorType;

    /// <summary>
    /// 在 Action 被呼叫之前或之後執行動作。
    /// </summary>
    /// <param name="context"></param>
    /// <param name="next"></param>
    /// <returns></returns>
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var parameters = context.ActionArguments;
        if (parameters.Count <= 0)
        {
            await base.OnActionExecutionAsync(context, next);
        }

        var value = string.IsNullOrEmpty(this._parameterName)
                        ? parameters.FirstOrDefault().Value
                        : parameters.FirstOrDefault(o => o.Key.Equals(this._parameterName)).Value;

        if (value == null)
        {
            context.Result = new BadRequestObjectResult("未輸入 Parameter");
        }
        else
        {
            var validationResult = await this.ExecuteValidationAsync(value);

            if (validationResult.IsValid.Equals(false))
            {
                var failureOutputModel = ConvertToFailResultViewModel(context, validationResult);

                context.Result = new BadRequestObjectResult(failureOutputModel);
            }
        }

        await base.OnActionExecutionAsync(context, next);
    }

    /// <summary>
    /// 將給定的 ActionExecutingContext 和 ValidationResult 轉換成 FailResultViewModel 物件。
    /// </summary>
    /// <param name="context"></param>
    /// <param name="validationResult"></param>
    /// <returns></returns>
    private static FailResultViewModel ConvertToFailResultViewModel(ActionExecutingContext context, ValidationResult validationResult)
    {
        // TODO: api version 功能尚未實作
        var failureOutputModel = new FailResultViewModel
        {
            Id = context.HttpContext.TraceIdentifier,
            ApiVersion = string.Empty,
            Method = $"{context.HttpContext.Request.Path}.{context.HttpContext.Request.Method}",
            Status = "ValidationError",
            Error = validationResult.Errors.Select(
                item => new FailInformation
                {
                    ErrorCode = 30001,
                    Message = item.ErrorMessage,
                    Description = item.ErrorMessage
                }).FirstOrDefault()
        };

        return failureOutputModel;
    }

    /// <summary>
    /// 執行驗證
    /// </summary>
    /// <param name="value">要被驗證的資料物件</param>
    /// <returns>傳回驗證結果</returns>
    private async Task<ValidationResult> ExecuteValidationAsync(object value)
    {
        var validationContext = new ValidationContext<object>(value);

        var validator = Activator.CreateInstance(this._validatorType) as IValidator;

        var validationResult = await validator!.ValidateAsync(validationContext);

        return validationResult;
    }
}
