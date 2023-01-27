using Serilog.Formatting.Display;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public static class LogConfig
    {
        public static readonly string Template =
            $"{{NewLine}}{{Timestamp:HH:mm:ss}} [{{Level}}] [{{{ClassNamePropertyName}}}.{{{MemberNamePropertyName}}}:{{{LineNumberPropertyName}}}] => {{Message}}{{NewLine}}{{Exception}}";

        public static MessageTemplateTextFormatter TemplateTextFormatter => new MessageTemplateTextFormatter(Template);

        public static string ClassNamePropertyName => "ClassName";
        public static string MemberNamePropertyName => "MemberName";
        public static string LineNumberPropertyName => "LineNumber";
    }
}