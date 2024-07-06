using API_DatingApp.Data;
using API_DatingApp.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DatingApp.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAll()
        {
            var users = await _dataContext.TbUsers.ToListAsync();
            return  Ok(users);
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<AppUser>> GetUserById(int userId)
        {
           AppUser currentUser = await _dataContext.TbUsers.Where(u=>u.id==userId).SingleOrDefaultAsync();

            if (currentUser==null) 
            {

                return BadRequest(new 
                {
                ErroreCode=202,
                ErroreMessage="invalid id"
                
                });
            }

            return Ok(currentUser);
        }
    }
}
