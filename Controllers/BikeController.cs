using Backend.Contract;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class BikeController : ControllerBase
{
    private IBikeService bikeService;

    public BikeController(IBikeService bikeService)
    {
        this.bikeService = bikeService;
    }

    [HttpPost]
    public IActionResult Insert(BikeDto dto)
    {
        bikeService.Insert(dto);
        return Ok(null);
    }

    [HttpGet]
    public IActionResult GetSingle(int id)
    {
        var result = bikeService.GetSingle(id);
        return Ok(result);
    }

    [HttpPut]
    public IActionResult Update(BikeDto dto)
    {
        bikeService.Update(dto);
        return Ok(null);
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        bikeService.Delete(id);
        return Ok(null);
    }

    [HttpGet("getAll")]
    public IActionResult GetAll()
    {
        var result = bikeService.GetAll();
        return Ok(result);
    }

    [HttpPost("getFiltered")]
    public IActionResult GetFiltered(BikeFilterParamDto filterParam)
    {
        var result = bikeService.GetFiltered(filterParam);
        return Ok(result);
    }
}