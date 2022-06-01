

using System;
using System.Threading.Tasks;
using Follow.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Follow.Models;
using CodeWorks.Auth0Provider;

namespace Follow.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class FollowsController : ControllerBase
  {
    private readonly FollowsService _fs;
    public FollowsController(FollowsService fs)
    {
      _fs = fs;
    }
    // CREATE follow
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<FollowModel>> Create([FromBody] FollowModel follow)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        follow.followerId = userInfo.Id;
        FollowModel newFollow = _fs.Create(follow);
        return Ok(newFollow);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // DELETE follow

    // GET follow by id
  }
}