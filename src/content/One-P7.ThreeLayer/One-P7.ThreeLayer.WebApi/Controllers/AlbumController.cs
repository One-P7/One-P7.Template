using Microsoft.AspNetCore.Mvc;
using ThreeLayer.Common.ActionFilters;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;
using ThreeLayer.Service.Queries;
using ThreeLayer.WebApi.Controllers.Parameters;
using ThreeLayer.WebApi.Controllers.Validators;
using ThreeLayer.WebApi.Controllers.ViewModel;

namespace ThreeLayer.WebApi.Controllers;

/// <summary>
/// 專輯 Controller
/// </summary>
/// <param name="albumsService"></param>
[Route("api/album")]
[ApiController]
public class AlbumController(IAlbumService albumsService) : ControllerBase
{
    /// <summary>
    /// 取得所有專輯
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<AlbumViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllAsync([FromQuery] AlbumListParameter parameter)
    {
        var query = new AlbumListQuery
        {
            Page = parameter.Page,
            PageSize = parameter.PageSize,
            Descending = parameter.Descending,
            Order = parameter.Order,
        };

        var resultDto = await albumsService.GetAllAsync(query);

        var viewModels = new ListResultViewModel<AlbumViewModel>
        {
            TotalCount = resultDto.TotalCount,
            Page = resultDto.Page,
            PageSize = resultDto.PageSize,
            Results = resultDto.Results.Select(ParseToViewModel)
        };

        return this.Ok(viewModels);
    }

    /// <summary>
    /// 根據 Id 取得專輯
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [ParameterValidator(typeof(AlbumGetByIdValidator))]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var dto = await albumsService.GetByIdAsync(id);

        var viewModel = ParseToViewModel(dto);

        return this.Ok(viewModel);
    }

    /// <summary>
    /// 解析成 View Model
    /// </summary>
    /// <param name="o"></param>
    /// <returns></returns>
    private static AlbumViewModel ParseToViewModel(AlbumDto o)
    {
        return new AlbumViewModel
        {
            AlbumId = o.AlbumId,
            Title = o.Title,
            ArtistId = o.ArtistId,
            ArtistName = o.ArtistName,
            Genre = o.Genre,
            Price = o.Price,
        };
    }
}
