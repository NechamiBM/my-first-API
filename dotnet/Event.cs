using System.Diagnostics.Metrics;

namespace dotnet
{
    public class Event
    {
        static int Counter = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Event() : this(DateTime.Now) { }
        public Event(DateTime date)
        {
            Id = Counter++;
            Start = date;
            Title = "sample event";
        }
    }
}
