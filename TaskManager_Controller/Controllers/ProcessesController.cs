using System.Diagnostics;
using TaskManager_Controller.Models;
using TaskManager_Controller.Models.Repositories;

namespace TaskManager_Controller.Controllers
{
    public class ProcessesController
    {
        private ProcessRepository processRepository;

        public ProcessesController()
        {
            processRepository = new ProcessRepository();

            AddAllProcesses();
        }
        public void AddProcess(ProcessModel process)
        {
            processRepository.AddProcess(process);
        }
        public void RemoveProcess(ProcessModel process)
        {
            processRepository.RemoveProcess(process);
        }
        public List<ProcessModel> GetAllProcesses()
        {
            return processRepository.GetAllProcesses();
        }
        private void AddAllProcesses()
        {
            Process[] allProcesses = Process.GetProcesses();

            foreach (Process systemProcess in allProcesses)
            {
                ProcessModel processModel = MapToProcessModel(systemProcess);
                processRepository.AddProcess(processModel);
            }
        }
        private ProcessModel MapToProcessModel(Process systemProcess)
        {
            return new ProcessModel
            {
                Id = systemProcess.Id,
                Name = systemProcess.ProcessName,
                CPUUsage = 0,
                MemoryUsage = systemProcess.WorkingSet64 / (1024 * 1024),
                Status = systemProcess.Responding ? "Running" : "Not Responding"
            };
        }
    }
}
