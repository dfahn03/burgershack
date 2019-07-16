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
      new Burger("Cheeseburger", 2, "er678"),
      new Burger("Bacon Cheeseburger", 2.50, "567yuk"),
      new Burger("Double Cheeseburger", 3.25, "345tyu")

  };
    // GET api/Burgers
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(Burgers);

    }

    // GET api/Burgers/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      try
      {
        return Ok(Burgers[id]);
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
