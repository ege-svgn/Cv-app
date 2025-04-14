namespace CVApp.Models
{
    public class CVModel
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;

        public List<string> Skills { get; set; } = new();
        public List<string> Education { get; set; } = new();
        public List<string> Experience { get; set; } = new();
    }
}