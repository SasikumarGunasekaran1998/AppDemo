using System.Collections.Generic;
using API.Data;
using API.Entites;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;

        }
[HttpGet]
public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
{
    return await _context.MyProperty.ToListAsync();
}
[HttpGet("{id}")]
public async Task<ActionResult<AppUser>> GetUser(int id)
{
    var user = _context.MyProperty.FindAsync(id);
    return await user;
}

    }
}