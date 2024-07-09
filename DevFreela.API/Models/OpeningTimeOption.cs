namespace DevFreela.API.Models
{
    public class OpeningTimeOption
    {
        public TimeSpan StartAt { get; set; }
        public TimeSpan FinishAt { get; set; }
        public object? OpeningTime { get; internal set; }
    }
}
