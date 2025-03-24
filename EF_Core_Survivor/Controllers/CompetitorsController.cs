using EF_Core_Survivor.Context;
using EF_Core_Survivor.Entities;
using EF_Core_Survivor.Models.Competitors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetitorsController : ControllerBase
{


    private readonly SurvivorDbContext _context;

    public CompetitorsController(SurvivorDbContext context)
    {
            _context = context;
    }

    [HttpGet]

    public IActionResult ListAll()
    {
        var competitors = _context.Competitors.Where(x => x.IsDeleted == false).Select(x => new CompetitorListResponse { Id = x.Id, CategoryId = x.CategoryId, FullName = x.FirstName+ " " + x.LastName}).ToList();

       

        return Ok(competitors);
    }

    [HttpGet("{id}")]

    public IActionResult List(int id) 
    {
        var competitor = _context.Competitors.Find(id);
        if (competitor == null || competitor.IsDeleted == true)
        {
            return NotFound();
        }

        var response = new CompetitorDetailResponse
        {
            Id = competitor.Id,
            FirstName = competitor.FirstName,
            LastName = competitor.LastName,
            CategoryId = competitor.CategoryId,
            CreatedDate = competitor.CreatedDate,
            ModifiedDate = competitor.ModifiedDate,
        };

        return Ok();
    }

    [HttpGet("category/{categoryId}")]
    public IActionResult ListByCategory(int categoryId)
    {
        var competitors = _context.Competitors.Where(x => x.CategoryId == categoryId && x.IsDeleted == false).Select(x => new CompetitorListResponse { Id = x.Id, CategoryId = x.CategoryId, FullName = x.FirstName + " " + x.LastName }).ToList();



        return Ok(competitors);
    }

    
    
    
    
    [HttpPost]

    public IActionResult Add(CompetitorAddRequest request)
    {
        
        var competitor = new CompetitorEntity
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            CategoryId = request.CategoryId,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
        };

        _context.Competitors.Add(competitor);
        _context.SaveChanges();

        return Ok(competitor);
    }


    [HttpPut("{id}")]
    public IActionResult Update(CompetitorUpdateRequest request,int id)
    {

        var competitor = _context.Competitors.Find(id);

        if (competitor == null || competitor.IsDeleted == true)
        {
            return NotFound();
        }

        competitor.FirstName = request.FirstName;
        competitor.LastName = request.LastName;
        competitor.CategoryId = request.CategoryId;
        competitor.ModifiedDate = DateTime.Now;

        _context.Competitors.Update(competitor);
        _context.SaveChanges();


        return Ok(competitor);
    }

   





    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var competitor = _context.Competitors.Find(id);

        if (competitor == null || competitor.IsDeleted == true)
        {
            return NotFound();
        }

        competitor.IsDeleted = true;
        competitor.ModifiedDate = DateTime.Now;

        _context.Competitors.Update(competitor);
        _context.SaveChanges();






        return Ok(competitor);
    }

}




