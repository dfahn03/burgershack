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
  public class DrinksController : ControllerBase
  {
    List<Drink> Drinks = new List<Drink>(){
      new Drink("Coke", 1.25, "67uihj"),
      new Drink("RootBeer", 1.25, "67uij"),
      new Drink("DrPepper", 1.25, "56yui")

  };
    // GET api/Drinks
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(Drinks);

    }

    // GET api/Drinks/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      try
      {
        return Ok(Drinks[id]);
      }
      catch (Exception e)
      {

        return BadRequest(e);
      }
    }

    // POST api/Drinks
    [HttpPost]
    public ActionResult<IEnumerable<Drink>> Post([FromBody] Drink newDrink)
    {
      Drinks.Add(newDrink);
      return Ok(Drinks);
    }

    // PUT api/Drinks/5
    [HttpPut("{id}")]
    public void Put(string id, [FromBody] string drink)
    {
    }

    // DELETE api/Drinks/5
    [HttpDelete("{id}")]
    public ActionResult Delete(string id)
    {
      try
      {
        Drink found = Drinks.Find(drink => drink.Id == id);
        if (found == null) return BadRequest(new { message = "Bad Id" });
        Drinks.Remove(found);
        return Ok(new { message = "Deleted" });
      }

      catch (Exception e)
      {
        return BadRequest(e);
      }
    }
  }
}
