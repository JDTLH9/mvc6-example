using System.Collections.Generic;

namespace mvc6_example.Models
{
    public class HomeModel
    {
        public string Greeting { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}
