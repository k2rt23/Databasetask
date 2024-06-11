using System.Collections.Generic;

public class LaenutavadAsjad
{
    public int LaenutavadAsjadId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<Laenutus> Laenutused { get; set; }
}