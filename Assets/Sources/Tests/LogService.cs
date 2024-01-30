using System;
using UnityEngine;

namespace Sources.Tests
{
    public class LogService : ILogService
    {
        private static int s_counter = 0;

        private readonly ILogServiceConfiguration _configuration;
        private readonly int _counter;

        public LogService(ILogServiceConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _counter = ++s_counter;
        }

        public void Write(string message)
        {
            Debug.Log(_counter);
            Debug.Log(message);
            Debug.Log(_configuration.DayOfWeek);
        }
    }
}