using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class Hardware
{
    public int IdH { get; set; }

    public int TypeH { get; set; }

    public int? Parent { get; set; }

    public int Status { get; set; }

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();

    public virtual ICollection<Disk> Disks { get; set; } = new List<Disk>();

    public virtual ICollection<HardwareValue> HardwareValues { get; set; } = new List<HardwareValue>();

    public virtual ICollection<History> HistoryComputerNavigations { get; set; } = new List<History>();

    public virtual ICollection<History> HistoryHardwareNewNavigations { get; set; } = new List<History>();

    public virtual ICollection<History> HistoryHardwareOldNavigations { get; set; } = new List<History>();

    public virtual ICollection<Hardware> InverseParentNavigation { get; set; } = new List<Hardware>();

    public virtual Hardware? ParentNavigation { get; set; }

    public virtual ICollection<Place> Places { get; set; } = new List<Place>();

    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();

    public virtual StatusDict StatusNavigation { get; set; } = null!;

    public virtual HardwareType TypeHNavigation { get; set; } = null!;
}
