using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modulo_Clinica.Models;

namespace Modulo_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private readonly ClinicaContext _context;

        public HospitalesController(ClinicaContext context)
        {
            _context = context;
        }

        // GET: api/Hospitales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospital>>> GetHospitales()
        {
            return await _context.Hospitales.ToListAsync();
        }

        // GET: api/Hospitales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hospital>> GetHospital(int id)
        {
            var hospital = await _context.Hospitales.FindAsync(id);

            if (hospital == null)
            {
                return NotFound();
            }

            return hospital;
        }

        // PUT: api/Hospitales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospital(int id, Hospital hospital)
        {
            if (id != hospital.HospitalId)
            {
                return BadRequest();
            }

            _context.Entry(hospital).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospitalExists(id))
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

        // POST: api/Hospitales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hospital>> PostHospital(Hospital hospital)
        {
            _context.Hospitales.Add(hospital);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHospital", new { id = hospital.HospitalId }, hospital);
        }

        // DELETE: api/Hospitales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospital(int id)
        {
            var hospital = await _context.Hospitales.FindAsync(id);
            if (hospital == null)
            {
                return NotFound();
            }

            _context.Hospitales.Remove(hospital);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HospitalExists(int id)
        {
            return _context.Hospitales.Any(e => e.HospitalId == id);
        }
    }
}
