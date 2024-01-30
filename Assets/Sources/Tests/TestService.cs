using System;

namespace Sources.Tests
{
    public class TestService : ITestService
    {
        private readonly ILogService _logService;

        public TestService(ILogService logService)
        {
            _logService = logService ?? throw new ArgumentNullException(nameof(logService));
        }

        public void Run()
        {
            _logService.Write("TestService is running");
        }
    }
}