using grade.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
//CRUD for Items
[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private static List<Item> materials = new List<Item>();

    [HttpPost]
    public ActionResult<Item> AddItem(Item material)
    {
        materials.Add(material);
        return CreatedAtAction(nameof(GetMaterial), new { id = material.ItemId }, material);
    }

    [HttpGet("{id}")]
    public ActionResult<Item> GetMaterial(int id)
    {
        var material = materials.FirstOrDefault(m => m.ItemId == id);
        if (material == null) return NotFound();
        return material;
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMaterial(int id)
    {
        var material = materials.FirstOrDefault(m => m.ItemId == id);
        if (material == null) return NotFound();
        materials.Remove(material);
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMaterial(int id, Item material)
    {
        var existingMaterial = materials.FirstOrDefault(m => m.ItemId == id);
        if (existingMaterial == null) return NotFound();
        existingMaterial.Name = material.Name;
        existingMaterial.Description = material.Description;
        existingMaterial.Description = material.Description;

        return NoContent();
    }
}

