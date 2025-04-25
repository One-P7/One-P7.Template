using FluentValidation;

namespace ThreeLayer.WebApi.Controllers.Validators;

/// <summary>
/// 驗證 ArtistController.GetByIdAsync 方法的 Id 參數
/// </summary>
public class ArtistGetByIdValidator : AbstractValidator<int>
{
    public ArtistGetByIdValidator()
    {
        this.RuleFor(x => x).NotEmpty().WithMessage("Id 不能為空");
        this.RuleFor(x => x).GreaterThan(0).WithMessage("Id 必須大於 0");
    }
}
