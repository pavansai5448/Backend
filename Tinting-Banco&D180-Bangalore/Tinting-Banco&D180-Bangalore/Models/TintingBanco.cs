namespace Tinting_Banco_D180_Bangalore.Models
{
    public class TintingBanco
    {
        public int day { get; set; }

        public int month { get; set; }

        public int year { get; set; }
        public DateOnly Date { get; set; }

        public string NameOfTheProject { get; set; } = null!;

        public string FanDeck { get; set; } = null!;

        public string ShadeCode { get; set; } = null!;

        public string ShadeName { get; set; } = null!;

        public string Product { get; set; } = null!;

        public string Base { get; set; } = null!;

        public string BaseBatchNo { get; set; } = null!;

        public string FormulationFor1LitrePackSize { get; set; } = null!;

        public int QuantityTintedInLitres { get; set; }

        public string Reference { get; set; } = null!;

        public string ForProjectOrRetail { get; set; } = null!;

        public string ShadeMatchConfirmation { get; set; } = null!;

        public string? ShadePatchSwatch { get; set; }

        public string OtherObservations { get; set; } = null!;

        public string DispensingMachine { get; set; } = null!;
    }


}
