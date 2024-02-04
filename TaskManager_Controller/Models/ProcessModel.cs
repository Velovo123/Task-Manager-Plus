namespace TaskManager_Controller.Models
{
    public class ProcessModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float CPUUsage { get; set; }
        public long MemoryUsage { get; set; }
        public string Status { get; set; } = string.Empty;


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, CPU Usage: {CPUUsage}%, Memory Usage: {MemoryUsage} MB, Status: {Status}";
        }
    }
}
