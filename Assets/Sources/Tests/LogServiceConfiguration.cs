using System;

namespace Sources.Tests
{
    public class LogServiceConfiguration : ILogServiceConfiguration
    {
        public LogServiceConfiguration(DayOfWeek dayOfWeek) => 
            DayOfWeek = dayOfWeek;

        public DayOfWeek DayOfWeek { get; }
    }
}