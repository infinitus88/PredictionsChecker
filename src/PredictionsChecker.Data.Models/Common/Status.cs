using System.ComponentModel;

namespace PredictionsChecker.Data.Models.Common
{
    public enum Status : byte
    {
        [Description("won")]
        Won = 1,

        [Description("lost")]
        Lost = 0,

        [Description("postponed")]
        Postponed = 3,

        [Description("pending")]
        Pending = 4
    }
}
