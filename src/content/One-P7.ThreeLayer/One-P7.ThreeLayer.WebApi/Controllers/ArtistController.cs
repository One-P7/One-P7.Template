using Microsoft.AspNetCore.Mvc;
using ThreeLayer.Service.Dtos;
using ThreeLayer.Service.Interfaces;
using ThreeLayer.WebApi.Controllers.ViewModel;

namespace ThreeLayer.WebApi.Controllers;

/// <summary>
/// 藝術家 Controller
/// </summary>
/// <param name="artistsService"></param>
[Route("api/artists")]
[ApiController]
public class ArtistController(IArtistService artistsService) : ControllerBase
{
    /// <summary>
    /// 取得所有藝術家
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var dtos = await artistsService.GetAllAsync();

        var viewModels = dtos.Select(ParseToViewModel);

        return this.Ok(viewModels);
    }

    /// <summary>
    /// 根據 Id 取得藝術家
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var dto = await artistsService.GetByIdAsync(id);

        var viewModel = ParseToViewModel(dto);

        return this.Ok(viewModel);
    }

    /// <summary>
    /// 解析成 View Model
    /// </summary>
    /// <param name="o"></param>
    /// <returns></returns>
    private static ArtistViewModel ParseToViewModel(ArtistDto o)
    {
        return new ArtistViewModel
        {
            ArtistId = o.ArtistId,
            Name = o.Name,
            AlbumCount = o.AlbumCount,
            TracksCount = o.TracksCount
        };
    }
}
