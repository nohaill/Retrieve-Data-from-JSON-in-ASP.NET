using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Retrieving_Data_from_JSON_file_in_Asp.Net.Models;
using Retrieving_Data_from_JSON_file_in_Asp.Net.Services;

namespace Retrieving_Data_from_JSON_file_in_Asp.Net.Pages
{
    public class EmployeesModel : PageModel
    {
        public JsonEmployeesService EmployeesService;
        public IEnumerable<Employees> Employee { get; private set; } = new List<Employees>();

        public EmployeesModel(JsonEmployeesService employeesService)
        {

            EmployeesService = employeesService;
        }
        public void OnGet()
        {

            var employees = EmployeesService.GetEmployees();
            if (employees != null)
            {
                Employee = employees;
            }
            else
            {
                Employee = new List<Employees>(); 
            }
        }
    }
}
