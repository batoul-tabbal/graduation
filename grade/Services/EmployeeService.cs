using grade.FixedAssets;
using grade.Services;
using System.Data.Entity.Migrations;

public class EmployeeService : IEmployeeService
{
    private readonly MyDbContext _context;

    public EmployeeService(MyDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Employe> GetAll() => _context.Employes.ToList();

    public Employe GetById(int id) => _context.Employes.Find(id);

    public void Add(Employe employee)
    {
        _context.Employes.Add(employee);
        _context.SaveChanges();
    }

    public void Update(Employe employee)
    {
        _context.Employes.AddOrUpdate(employee);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var employee = _context.Employes.Find(id);
        if (employee != null)
        {
            _context.Employes.Remove(employee);
            _context.SaveChanges();
        }
    }
}
