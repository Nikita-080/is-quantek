using System;
using System.Collections.Generic;

namespace InformSystem.dataBase;

public partial class DepartmentDict
{
    public int IdDd { get; set; }

    public string NameD { get; set; } = null!;

    public virtual ICollection<Place> Places { get; set; } = new List<Place>();
}
