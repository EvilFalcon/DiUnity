using System.Collections;
using NUnit.Framework;
using Sources.DiTests.Tests.Objects;
using Sources.DiTests.Tests.Singletons;
using UniCtor.Builders;
using UniCtor.Factories;
using UnityEngine.TestTools;

namespace Sources.DiTests.Tests
{
    public class DiTest
    {
        private IDependencyResolver _resolver;

        [SetUp]
        public void Setup()
        {
            _resolver = new DependencyResolverFactory().Create();
            _resolver.Services.RegisterAsSingleton<ILogService, LogService>();
            _resolver.Services.RegisterAsScoped<IScopedService, ScopedService>();
        }

        // A Test behaves as an ordinary method
        [Test]
        public void SingletonTest()
        {
            // Use the Assert class to test conditions
            var service = _resolver.Resolve<SingletonTest>();
            Assert.IsNotNull(service);
        }

        [Test]
        public void SingletonTest2()
        {
            // Use the Assert class to test conditions
            var service = _resolver.Resolve<SingletonTest>();
            Assert.IsNotNull(service.LogService);
        }

        [Test]
        public void ScopedTest1()
        {
            // Use the Assert class to test conditions
            var resolver = _resolver.Resolve<IDependencyResolver>();

            resolver.Services.RegisterAsScoped<IScopedService, ScopedService>();
            var service = _resolver.Resolve<IScopedService>();
            var service2 = resolver.Resolve<IScopedService>();
            Assert.AreNotEqual(service, service2);
        }

        [Test]
        public void ScopedTest2()
        {
            // Use the Assert class to test conditions
            var service = _resolver.Resolve<IScopedService>();
            var service2 = _resolver.Resolve<IScopedService>();
            Assert.AreEqual(service, service2);
        }


        [Test]
        public void ScopedTest3()
        {
            // Use the Assert class to test conditions
            var resolver = _resolver.Resolve<IDependencyResolver>();

            var service = _resolver.Resolve<IScopedService>();
            var service2 = resolver.Resolve<IScopedService>();
            Assert.AreEqual(service, service2);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}