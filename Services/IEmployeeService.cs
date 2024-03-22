using Employee_Management_System.Models;

namespace Employee_Management_System.Services
{
    public interface IEmployeeService
    {

        
        List<Employee> Get();

        Employee Get(string id);
        Employee Create(Employee employee);
        void Update(string id, Employee employee);

        void Remove(string id);
    }
}
