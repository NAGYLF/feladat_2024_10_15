using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using static WebApplication2.Models.Dto;

namespace WebApplication12.Controllers
{
    [Route("targyak")]
    [ApiController]
    public class TantargyController : ControllerBase
    {
     
     
            [HttpGet]
            public ActionResult<List<Targy>> Get()
            {
                using (var context = new TargyDbContext())
                {
                    return StatusCode(201, context.NewTargy.ToList());
                }
            }

            [HttpGet("{azon}")]
            public ActionResult<Targy> GetById(Guid azon)
            {
                using (var context = new TargyDbContext())
                {
                    return StatusCode(200, context.NewTargy.FirstOrDefault(x => x.Azon == azon));
                }
            }

            [HttpPost]
            public ActionResult<Targy> Post(CreateTargyDto createTargyDto)
            {
                var targy = new Targy
                {
                    Azon = Guid.NewGuid(),
                    Jegy = createTargyDto.Jegy,
                    Leiras = createTargyDto.Leiras,
                    Letrehozas_ideje = createTargyDto.Letrohazs_ideje,
                };

                using (var context = new TargyDbContext())
                {
                    context.NewTargy.Add(targy);
                    context.SaveChanges();

                    return StatusCode(201, targy);
                }
            }
        
            [HttpPut("{azon}")]
            public ActionResult<Targy> Put(Guid azon, UpdateTargyDto updateTargyDto)
            {
                using (var context = new TargyDbContext())
                {
                    var existingTargy = context.NewTargy.FirstOrDefault(x => x.Azon == azon);

                existingTargy.Leiras = updateTargyDto.Leiras;
                existingTargy.Jegy = updateTargyDto.Jegy;
                existingTargy.Letrehozas_ideje = updateTargyDto.Letrohazs_ideje;
               

                    context.NewTargy.Update(existingTargy);
                    context.SaveChanges();

                    return StatusCode(200, existingTargy);
                }
            }

            [HttpDelete]
            public ActionResult<object> Delete(Guid azon)
            {
                using (var context = new TargyDbContext())
                {
                    var targy = context.NewTargy.FirstOrDefault(x => x.Azon == azon);

                    if (targy != null)
                    {
                        context.NewTargy.Remove(targy);
                        context.SaveChanges();
                        return StatusCode(200, new { message = "Sikeres törlés!" });
                    }

                }
                return StatusCode(404, new { message = "Nincs ilyen felhasználó!" });
            }
        
    }
}
