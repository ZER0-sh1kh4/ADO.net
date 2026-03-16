using System;
using System.Collections.Generic;

namespace ONEtoONEapi.Models;

public partial class Hostel
{
    public int HostelId { get; set; }

    public int? RoomNumber { get; set; }

    public virtual Student? Student { get; set; }
}
