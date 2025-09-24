using DevelopmentSucks2.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentSucks2.API.Controllers;

[ApiController]
[Route("[controller")]
public class ChaptersController: ControllerBase
{
    private IChaptersService _chapterService;

    public ChaptersController(IChaptersService chapterService)
    {
        _chapterService = chapterService;
    }


}
