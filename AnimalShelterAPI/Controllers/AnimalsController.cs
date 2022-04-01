using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterAPI.Models;

namespace Animals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalShelterAPIContext _context;

        public AnimalsController(AnimalShelterAPIContext context)
        {
            _context = context;
        }

        // GET: api/Animals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
        {
            return await _context.Animals.ToListAsync();
        }

        // GET: api/Animals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }

         // POST: api/Animals
        [HttpPost]
        public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
        }


    }
}