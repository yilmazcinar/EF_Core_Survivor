using EF_Core_Survivor.Context;
using EF_Core_Survivor.Entities;
using EF_Core_Survivor.Models.Categories;
using EF_Core_Survivor.Models.Competitors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Survivor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{

    private readonly SurvivorDbContext _context;

    public CategoriesController(SurvivorDbContext context)

    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Add(CategoryAddRequest request)
    {
        var category = new CategoryEntity
        {
            Name = request.Name,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now,

        };


        _context.Categories.Add(category);
        _context.SaveChanges();

        return Created();
    }

    [HttpGet]
    public IActionResult ListAll()
    {
        var categories = _context.Categories.Where(x => x.IsDeleted == false).Select(x => new CategoryListResponse { Id = x.Id, Name = x.Name}).ToList();





        return Ok(categories);
    }

   

    [HttpGet("{id}")]

    public IActionResult ListCompetitors(int id)
    {
       var category = _context.Categories.Include(x => x.Competitors).FirstOrDefault(x => x.Id == id);

        if (category == null || category.IsDeleted == true)
        {
            return NotFound();
        }

        var response = new CategoryDetailResponse
        {
            Id = category.Id,
            Name = category.Name,
            CreatedDate = category.CreatedDate,
            ModifiedDate = category.ModifiedDate,
            Competitors = category.Competitors.
            Where(x => x.IsDeleted == false).
            Select(x => new CompetitorListResponse { Id = x.Id, FullName = x.FirstName+ " " +x.LastName , CategoryId = x.CategoryId }).ToList()
        };

        return Ok(response);
    }





    [HttpPut("{id}")]
    public IActionResult Update(CategoryUpdateRequest request,int id) 
    {
        var category = _context.Categories.Find(id);

        if (category == null || category.IsDeleted == true)
        {
            return NotFound();
        }

        category.Name = request.Name;
        category.ModifiedDate = DateTime.Now;

      _context.Categories.Update(category);
        _context.SaveChanges();


        return Ok();
    }

   
    [HttpDelete("{id}")]
    public IActionResult Delete(int id) 
    {
        var category = _context.Categories.Find(id);

        if (category == null || category.IsDeleted == true)
        {
            return NotFound();
        }

        category.IsDeleted = true;
        category.ModifiedDate = DateTime.Now;

        _context.Categories.Update(category);
        _context.SaveChanges();

        return Ok();    
    }

}
