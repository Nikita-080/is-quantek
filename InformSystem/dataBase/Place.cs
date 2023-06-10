using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class Place
{
    public int IdP { get; set; }

    public int HardwareP { get; set; }

    public int DepartmentId { get; set; }

    public int Building { get; set; }

    public int Floor { get; set; }

    public int Office { get; set; }

    public DateTime Data { get; set; }

    public virtual DepartmentDict Department { get; set; } = null!;

    public virtual Hardware HardwarePNavigation { get; set; } = null!;
}
