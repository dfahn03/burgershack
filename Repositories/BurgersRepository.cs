using System.Collections.Generic;
using System.Data;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
  public class BurgerRepository
  {
    private readonly IDbConnection _db;

    public BurgerRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Burger> GetAll()
    {
      return _db.Query<Burger>("SELECT * FROM burgers");
    }

  }

}
