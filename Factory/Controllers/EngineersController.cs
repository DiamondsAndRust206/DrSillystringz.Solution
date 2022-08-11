using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Factory.Models;

namespace Factory.Controllers
{
  public class EngineersController :Controller
  {
    public readonly FactoryContext _db;

    public EngineersController( FactoryContext db)
    {
      _db =db;
    }
    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }
    
  }
}