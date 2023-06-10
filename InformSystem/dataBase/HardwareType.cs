using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class HardwareType
{
    public int IdHt { get; set; }

    public string NameT { get; set; } = null!;

    public virtual ICollection<HardwareProperty> HardwareProperties { get; set; } = new List<HardwareProperty>();

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();
}
