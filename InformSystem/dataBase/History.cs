using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class History
{
    public int IdHi { get; set; }

    public int Computer { get; set; }

    public int? HardwareOld { get; set; }

    public int? HardwareNew { get; set; }

    public DateTime DateH { get; set; }

    public virtual Hardware ComputerNavigation { get; set; } = null!;

    public virtual Hardware? HardwareNewNavigation { get; set; }

    public virtual Hardware? HardwareOldNavigation { get; set; }
}
