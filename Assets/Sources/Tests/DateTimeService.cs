using System;

namespace Sources.Tests
{
    public class DateTimeService : IDateTimeService
    {
        public DayOfWeek LogDay { get; } = DayOfWeek.Friday;
    }
}