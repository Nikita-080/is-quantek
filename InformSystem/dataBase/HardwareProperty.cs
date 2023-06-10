using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class HardwareProperty
{
    public int IdHp { get; set; }

    public int TypeP { get; set; }

    public int NameP { get; set; }

    public virtual ICollection<HardwareValue> HardwareValues { get; set; } = new List<HardwareValue>();

    public virtual HardwareType TypePNavigation { get; set; } = null!;
}
