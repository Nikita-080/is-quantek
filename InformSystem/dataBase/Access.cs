using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class Access
{
    public int IdA { get; set; }

    public int HardwareA { get; set; }

    public int Person { get; set; }

    public virtual Hardware HardwareANavigation { get; set; } = null!;
}
