using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class Repair
{
    public int IdR { get; set; }

    public int HardwareR { get; set; }

    public DateTime? DateIn { get; set; }

    public DateTime? DateOut { get; set; }

    public int? DocumentIn { get; set; }

    public int? DocumentOut { get; set; }

    public string Reason { get; set; } = null!;

    public string Verdict { get; set; } = null!;

    public virtual Hardware HardwareRNavigation { get; set; } = null!;
}
