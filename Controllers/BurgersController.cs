using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BurgersController : ControllerBase
  {
    List<Burger> Burgers = new List<Burger>(){
      new Burger("er678", "Cheeseburger", "Bun, patty, pepperjack cheese, lettuce and tomato", 2),
      new Burger("567yuk", "Bacon Cheeseburger", "Bun, patty, peppered bacon, jalepeno pepperjack cheese, lettuce and tomato ", 2.50),
      new Burger("345tyu", "Double Cheeseburger", "Like the cheeseburger but doubled", 3.25)

  };
    // GET api/Burgers
    [HttpGet]
    public ActionResult<IEnumerable<Burger>> Get()
    {
      try
      {
        return Ok(Burgers);

      }
      catch (Exception e)
      {
        return BadRequest(e);
      }


    }

    // GET api/Burgers/5
    [HttpGet("{id}")]
    public ActionResult<Burger> Get(string id)
    {
      try
      {
        Burger found = Burgers.Find(burger => burger.Id == id);
        if (found == null)
        {
          return BadRequest("No burger with that Id.");
        }
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }

    // POST api/Burgers
    [HttpPost]
    public ActionResult<IEnumerable<Burger>> Post([FromBody] Burger newBurger)
    {
      Burgers.Add(newBurger);
      return Ok(Burgers);
    }

    // PUT api/Burgers/5
    [HttpPut("{id}")]
    public void Put(string id, [FromBody] string Burger)
    {
    }

    // DELETE api/Burgers/5
    [HttpDelete("{id}")]
    public ActionResult Delete(string id)
    {
      try
      {
        Burger found = Burgers.Find(Burger => Burger.Id == id);
        if (found == null) return BadRequest(new { message = "Bad Id" });
        Burgers.Remove(found);
        return Ok(new { message = "Deleted" });
      }

      catch (Exception e)
      {
        return BadRequest(e);
      }
    }
  }
}
