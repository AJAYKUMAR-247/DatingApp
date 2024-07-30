using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
   

    // [HttpGet]
    // public ActionResult<IEnumerable<AppUser>> GetUsers()
    // {
    //     var users = context.Users.ToList();

    //     return users;
    // }

    // [HttpGet("{id:int}")] 
    // public ActionResult<AppUser> GetUser(int id)
    // {
    //     var user = context.Users.Find(id);

    //     if(user == null) return NotFound();

    //     return user;
    // }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id:int}")] 
    public async Task< ActionResult<AppUser> >GetUser(int id)
    {
        var user =  await context.Users.FindAsync(id);

        if(user == null) return NotFound();

        return user;
    }
}
