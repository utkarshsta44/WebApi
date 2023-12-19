using collegeApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace collegeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        // GET all action

        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
          Services.GetAll();

        // GET by Id action

        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = Services.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        // POST action

        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            // This code will save the pizza and return a result
            Services.Add(pizza);
            return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
        }

        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            // This code will update the pizza and return a result
            if (id != pizza.Id)
                return BadRequest();

            var existingPizza = Services.Get(id);
            if (existingPizza is null)
                return NotFound();

            Services.Update(pizza);

            return NoContent();
        }


        // DELETE action

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = Services.Get(id);

            if (pizza is null)
                return NotFound();

            Services.Delete(id);

            return NoContent();
        }
    }
}
