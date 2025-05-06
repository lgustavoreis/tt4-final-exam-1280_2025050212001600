using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAttendanceApi.Data;
using StudentAttendanceApi.Models;

namespace StudentAttendanceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentAttendancesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentAttendancesController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentAttendance>>> GetAll()
            => await _context.StudentAttendances.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentAttendance>> Get(int id)
        {
            var item = await _context.StudentAttendances.FindAsync(id);
            return item == null ? NotFound() : item;
        }

        [HttpPost]
        public async Task<ActionResult<StudentAttendance>> Create(StudentAttendance attendance)
        {
            _context.StudentAttendances.Add(attendance);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = attendance.Id }, attendance);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StudentAttendance attendance)
        {
            if (id != attendance.Id) return BadRequest();
            _context.Entry(attendance).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.StudentAttendances.FindAsync(id);
            if (item == null) return NotFound();
            _context.StudentAttendances.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
