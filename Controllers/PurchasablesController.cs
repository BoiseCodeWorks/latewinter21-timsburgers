using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;
using burgershack.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PurchasablesController : ControllerBase
  {
    private readonly MenuService _menuService;

    public PurchasablesController(MenuService menuService)
    {
      _menuService = menuService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<IPurchasable>> GetAllPurchasables()
    {
      try
      {
        return Ok(_menuService.getAll());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

  }
}