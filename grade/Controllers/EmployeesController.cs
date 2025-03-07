using grade.FixedAssets;
using grade.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
//new
[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _service;

    public EmployeesController(IEmployeeService service)
    {
        _service = service;
    }

   

    [HttpGet("{id}")]
    public ActionResult<Employe> Get(int id)
    {
        var employee = _service.GetById(id);
        if (employee == null) return NotFound();
        return employee;
    }

    [HttpPost]
    public ActionResult<Employe> Post(Employe employee)
    {
        _service.Add(employee);
        return CreatedAtAction(nameof(Get), new { id = employee.employeId }, employee);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Employe employee)
    {
        if (id != employee.employeId) return BadRequest();
        _service.Update(employee);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return NoContent();
    }
}
