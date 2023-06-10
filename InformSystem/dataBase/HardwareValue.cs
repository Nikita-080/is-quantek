using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class HardwareValue
{
    public int IdHv { get; set; }

    public int HardwareV { get; set; }

    public int Property { get; set; }

    public string Value { get; set; } = null!;

    public virtual Hardware HardwareVNavigation { get; set; } = null!;

    public virtual HardwareProperty PropertyNavigation { get; set; } = null!;
}
