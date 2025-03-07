using grade.FixedAssets;

namespace grade.Services
{
    //new
    public interface IEmployeeService
    {
        IEnumerable<Employe> GetAll();
        Employe GetById(int id);
        void Add(Employe employee);
        void Update(Employe employee);
        void Delete(int id);
    }

}
