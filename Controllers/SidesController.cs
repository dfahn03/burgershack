using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using burgershack.Models;

namespace Sideshack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SidesController : ControllerBase
  {
    List<Side> Sides = new List<Side>(){
      new Side("Fries", 1, "ghwkl"),
      new Side("Onion Rings", 1.50, "twygu"),
      new Side("Curly Fries", 1.25, "56wuhj")

  };
    // GET api/Sides
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(Sides);

    }

    // GET api/Sides/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      try
      {
        return Ok(Sides[id]);
      }
      catch (Exception e)
      {

        return BadRequest(e);
      }
    }

    // POST api/Sides
    [HttpPost]
    public ActionResult<IEnumerable<Side>> Post([FromBody] Side newSide)
    {
      Sides.Add(newSide);
      return Ok(Sides);
    }

    // PUT api/Sides/5
    [HttpPut("{id}")]
    public void Put(string id, [FromBody] string Side)
    {
    }

    // DELETE api/Sides/5
    [HttpDelete("{id}")]
    public ActionResult Delete(string id)
    {
      try
      {
        Side found = Sides.Find(Side => Side.Id == id);
        if (found == null) return BadRequest(new { message = "Bad Id" });
        Sides.Remove(found);
        return Ok(new { message = "Deleted" });
      }

      catch (Exception e)
      {
        return BadRequest(e);
      }
    }
  }
}
