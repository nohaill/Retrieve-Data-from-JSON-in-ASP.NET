using Retrieving_Data_from_JSON_file_in_Asp.Net.Models;
using System.Text.Json;

namespace Retrieving_Data_from_JSON_file_in_Asp.Net.Services
{
    public class JsonEmployeesService
    {
        public JsonEmployeesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "employees.json"); }
        }

        public IEnumerable<Employees>? GetEmployees()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Employees[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
