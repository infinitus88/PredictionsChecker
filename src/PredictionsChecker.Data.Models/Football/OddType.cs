using System.ComponentModel;

namespace PredictionsChecker.Data.Models.Football
{
    public enum OddType
    {
        [Description("1")]
        First = 0,

        [Description("2")]
        Second = 1,

        [Description("12")]
        Any = 2,

        [Description("X")]
        Draw = 3,

        [Description("1X")]
        FirstOrDraw = 4,

        [Description("X2")]
        SecondOrDraw = 5
    }
}
