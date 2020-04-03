using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MasterAnimalShelter.Models; //so many errors udk how to remove

namespace MasterAnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private MasterAnimalShelterContext _db;
      public AnimalsController(MasterAnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/Animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return  _db.Animals.ToList();
    }

    // GET api/Animals/5
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return thisAnimal;
    }

    // POST api/Animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    // PUT api/Animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id; //wanting to understand better
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/Animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Animal deletingAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId ==id);
      _db.Animals.Remove(deletingAnimal);
      _db.SaveChanges();
    }
  }
}
