using PayrollManagementModels;

namespace PayrollManagementDataServices
{
    public class PayrollDataService
    {
        IEmployeeDataService dataservice;
        public PayrollDataService(IEmployeeDataService iEmployeeDataService)
        {
            dataservice = iEmployeeDataService;
        }
        public void Add(Employee employ)
        {
            dataservice.Add(employ);
        }

        public List<Employee> GetEmployee()
        {
            return dataservice.GetEmployee();
        }

        public void UpdateEmployee(Employee employee)
        {
            dataservice.UpdateEmployee(employee);
        }
        public Employee? SearchByEmployee(Guid id)
        {
            return dataservice.SearchEmployee(id);
        }

    }
}
