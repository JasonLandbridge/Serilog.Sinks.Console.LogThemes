using System.Drawing;
using Xunit;

namespace Serilog.Sinks.Console.LogThemes.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LogTheme.Style(Color.Gray);
            LogTheme.Style(Color.White, Color.Black);
            LogTheme.Style(Color.White, Color.Black, FormatTypeEnum.BoldMode);
            LogTheme.Style(Color.White, FormatTypeEnum.BoldMode);

            LogTheme.Foreground(Color.Gray).FormatType(FormatTypeEnum.ItalicMode).ToStyle();
        }
    }
};