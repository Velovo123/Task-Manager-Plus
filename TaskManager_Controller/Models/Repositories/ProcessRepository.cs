namespace TaskManager_Controller.Models.Repositories
{
    public class ProcessRepository
    {
        private List<ProcessModel>? processes;

        public ProcessRepository()
        {
            processes = new List<ProcessModel>();
        }

        public void AddProcess(ProcessModel process)
        {
            processes?.Add(process);
        }

        public void RemoveProcess(ProcessModel process)
        {
            processes?.Remove(process);
        }
        public List<ProcessModel>? GetAllProcesses()
        {
            return processes;
        }
    }
}
