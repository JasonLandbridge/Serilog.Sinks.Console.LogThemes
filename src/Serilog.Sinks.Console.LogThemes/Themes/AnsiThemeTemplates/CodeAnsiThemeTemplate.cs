using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Sinks.Console.LogThemes
{
    public class CodeAnsiThemeTemplate : AnsiBaseTheme
    {
        protected override string Text => LogTheme.Foreground(Color256.Grey253);
        protected override string SecondaryText => LogTheme.Foreground(Color256.Grey246);
        protected override string TertiaryText => LogTheme.Foreground(Color256.Grey242);
        protected override string Invalid => LogTheme.Foreground(Color16.YellowBold);
        protected override string Null => LogTheme.Foreground(Color256.DeepSkyBlue38);
        protected override string Name => LogTheme.Foreground(Color256.SteelBlue81);
        protected override string String => LogTheme.Foreground(Color256.LightSalmon216);
        protected override string Number => LogTheme.Foreground(Color256.DarkSeaGreen151);
        protected override string Boolean => LogTheme.Foreground(Color256.DeepSkyBlue38);
        protected override string Scalar => LogTheme.Foreground(Color256.Aquamarine79);
        protected override string LevelVerbose => LogTheme.Foreground(Color16.White);
        protected override string LevelDebug => LogTheme.Foreground(Color16.White);
        protected override string LevelInformation => LogTheme.Foreground(Color16.WhiteBold);
        protected override string LevelWarning => LogTheme.Foreground(Color256.Wheat229);
        protected override string LevelError => LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238);
        protected override string LevelFatal => LogTheme.Foreground(Color256.DeepPink197).Background(Color256.Grey238);
    }
}