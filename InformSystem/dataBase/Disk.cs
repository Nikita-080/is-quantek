using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class Disk
{
    public int IdD { get; set; }

    public string Creator { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Size { get; set; }

    public int HardwareD { get; set; }

    public virtual Hardware HardwareDNavigation { get; set; } = null!;
}
