using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.NoSql
{
    [Serializable]
    public enum LevelEnum
    {
        [Description("Info")]
        Info = 0,
        [Description("Warning")]
        Warning = 1,
        [Description("Error")]
        Error = 2,
        [Description("Fatal")]
        Fatal = 3
    }
}
