using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class StatusDict
{
    public int IdS { get; set; }

    public string NameS { get; set; } = null!;

    public virtual ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();
}
