namespace Serilog.Sinks.Console.LogThemes.Demo
{
    public class LogThemeDemoConfig
    {
        public bool RandomForeground { get; set; } = true;

        public bool RandomBackground { get; set; } = true;

        public bool RandomFormatType { get; set; } = true;

        public int DelayBetweenLogs { get; set; } = 30;

        public int Loops { get; set; } = 50;

        public bool UseColor256 { get; set; } = false;
    }
}