using UniCtor.Attributes;
using UnityEngine;

namespace Sources.Tests
{
    public class Bootstrapper : MonoBehaviour
    {
        [Constructor]
        private void Construct(ITestService testService, ITestService testService2)
        {
            testService.Run();
            testService2.Run();
        }
    }
}