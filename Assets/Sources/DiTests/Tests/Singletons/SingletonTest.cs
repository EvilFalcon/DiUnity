using Sources.DiTests.Tests.Objects;

namespace Sources.DiTests.Tests.Singletons
{
    public class SingletonTest
    {

        public SingletonTest(ILogService logService)
        {
            LogService = logService;
        }
        
        public ILogService LogService { get; }
    }
}