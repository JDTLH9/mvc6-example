namespace mvc6_example.Models
{
    public static class StatusClass
    {
        public const string DEFAULT = "default";
        public const string SUCCESS = "success";
        public const string WARNING = "warning";
        public const string DANGER = "danger";
    }

    public class Status
    {
        public string Message { get; set; }
        public string Style { get; set; }
    }
}
