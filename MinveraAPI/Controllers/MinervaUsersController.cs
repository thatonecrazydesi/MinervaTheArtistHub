using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinveraAPI.Models;

namespace MinveraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinervaUsersController : ControllerBase
    {
        private readonly MinervaDbContext _context;

        public MinervaUsersController(MinervaDbContext context)
        {
            _context = context;
        }

        // GET: api/MinervaUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MinervaUsers>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/MinervaUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MinervaUsers>> GetMinervaUsers(int id)
        {
            var minervaUsers = await _context.Users.FindAsync(id);

            if (minervaUsers == null)
            {
                return NotFound();
            }

            return minervaUsers;
        }

        // PUT: api/MinervaUsers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMinervaUsers(int id, MinervaUsers minervaUsers)
        {
            minervaUsers.userId = id;

            _context.Entry(minervaUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MinervaUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MinervaUsers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MinervaUsers>> PostMinervaUsers(MinervaUsers minervaUsers)
        {
            _context.Users.Add(minervaUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMinervaUsers", new { id = minervaUsers.userId }, minervaUsers);
        }

        // DELETE: api/MinervaUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MinervaUsers>> DeleteMinervaUsers(int id)
        {
            var minervaUsers = await _context.Users.FindAsync(id);
            if (minervaUsers == null)
            {
                return NotFound();
            }

            _context.Users.Remove(minervaUsers);
            await _context.SaveChangesAsync();

            return minervaUsers;
        }

        private bool MinervaUsersExists(int id)
        {
            return _context.Users.Any(e => e.userId == id);
        }
    }
}
