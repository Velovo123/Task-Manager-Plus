using TaskManager_Controller.Controllers;

namespace TaskManager_Tests
{
    [TestClass]
    public class ProcessControllerTest
    {
        [TestMethod]
        public void AddProcess_ShouldAddProcessToRepository()
        {
            // Arrange
            ProcessesController processController = new ProcessesController();
            ProcessModel testProcess = new ProcessModel
            {
                Id = 123,
                Name = "TestProcess",
                CPUUsage = 10.5f,
                MemoryUsage = 256,
                Status = "Running"
            };

            // Act
            processController.AddProcess(testProcess);
            var allProcesses = processController.GetAllProcesses();

            // Assert
            CollectionAssert.Contains(allProcesses, testProcess);
        }

        [TestMethod]
        public void GetAllProcesses_ShouldReturnAllProcessesInRepository()
        {
            // Arrange
            ProcessesController processController = new ProcessesController();
            ProcessModel process1 = new ProcessModel { Id = 1, Name = "Process1" };
            ProcessModel process2 = new ProcessModel { Id = 2, Name = "Process2" };
            ProcessModel process3 = new ProcessModel { Id = 3, Name = "Process3" };

            // Act
            processController.AddProcess(process1);
            processController.AddProcess(process2);
            processController.AddProcess(process3);
            var allProcesses = processController.GetAllProcesses();

            // Assert
            CollectionAssert.Contains(allProcesses, process1);
            CollectionAssert.Contains(allProcesses, process2);
            CollectionAssert.Contains(allProcesses, process3);
        }
    }
}