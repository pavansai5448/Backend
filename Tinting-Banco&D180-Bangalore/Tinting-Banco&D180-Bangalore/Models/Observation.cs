using System;
using System.Collections.Generic;

namespace Tinting_Banco_D180_Bangalore.Models;

public partial class Observation
{
    public int Id { get; set; }

    public string Depot { get; set; } = null!;

    public int BaseTintedAsPerReportInLit { get; set; }

    public int BaseTintedAsPerHistoryFileInLit { get; set; }

    public int ColorantPouredInCannistersInLit { get; set; }

    public int ColorantConsumedInLit { get; set; }

    public string? Remarks { get; set; }

    public string BrandlingForDispensingMachine { get; set; } = null!;

    public string BrandlingForGyroshakerMachine { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public int Status { get; set; }

    public DateOnly EntryDate { get; set; }
}
