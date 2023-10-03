using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tinting_Banco_D180_Bangalore.Models;
using System;
namespace Tinting_Banco_D180_Bangalore.Controllers
{
    [ApiController]
    [EnableCors("corspolicy")]

    public class TintedController : ControllerBase
    {
        private TintingDepotRecordsContext tdrc;
        public TintedController(TintingDepotRecordsContext tdrc)
        {
            this.tdrc = tdrc;
        }

        [HttpPost]
        [Route("api/tinting/post")]
        public async void AddContact([FromBody] TintingBanco observationRequest)
        {
            int day = observationRequest.day;
            int month = observationRequest.month;
            int year = observationRequest.year;
            DateOnly d1 = new DateOnly(year, month, day);
            TintingBancoD180Bangalore ob = new TintingBancoD180Bangalore
            {

                Date = d1,
                NameOfTheProject = observationRequest.NameOfTheProject,
                FanDeck = observationRequest.FanDeck,
                ShadeCode = observationRequest.ShadeCode,
                ShadeName = observationRequest.ShadeName,
                Product = observationRequest.Product,
                Base = observationRequest.Base,
                BaseBatchNo = observationRequest.BaseBatchNo,
                FormulationFor1LitrePackSize = observationRequest.FormulationFor1LitrePackSize,
                QuantityTintedInLitres = observationRequest.QuantityTintedInLitres,
                Reference = observationRequest.Reference,
                ForProjectOrRetail = observationRequest.ForProjectOrRetail,
                ShadeMatchConfirmation = observationRequest.ShadeMatchConfirmation,
                ShadePatchSwatch = observationRequest.ShadePatchSwatch,
                OtherObservations = observationRequest.OtherObservations,
                DispensingMachine = observationRequest.DispensingMachine,

            };
            tdrc.TintingBancoD180Bangalores.Add(ob);
            tdrc.SaveChanges();

        }
    }
}

