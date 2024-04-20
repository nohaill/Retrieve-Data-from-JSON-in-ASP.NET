using System.Text.Json;

namespace Retrieving_Data_from_JSON_file_in_Asp.Net.Models
{
    public class Employees
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Department { get; set; }

        public Employees()
        {
            Name = string.Empty; 
            Department = string.Empty;
        }
        public override string ToString() => JsonSerializer.Serialize<Employees>(this);
        


    }
}
