
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using Tinting_Banco_D180_Bangalore.Models;

namespace Nippon.Controller
{


    [ApiController]
    [EnableCors("corspolicy")]
    public class ObservationController : ControllerBase
    {
        private TintingDepotRecordsContext tdrc;
        public ObservationController(TintingDepotRecordsContext tdrc)
        {
            this.tdrc = tdrc;
        }
        [HttpPost]
        [Route("api/observation/post")]
        public async void AddContact([FromBody] ObservationRequest observationRequest)
        {
            int day = observationRequest.day;
            int month = observationRequest.month;
            int year = observationRequest.year;
            DateOnly d1 = new DateOnly(year, month, day);
            Observation ob = new Observation
            {
                Depot = observationRequest.Depot,
                EntryDate = d1,
                BaseTintedAsPerReportInLit = observationRequest.BaseTintedAsPerReportInLit,
                BaseTintedAsPerHistoryFileInLit = observationRequest.BaseTintedAsPerHistoryFileInLit,
                ColorantConsumedInLit = observationRequest.ColorantConsumedInLit,
                ColorantPouredInCannistersInLit = observationRequest.ColorantPouredInCannistersInLit,
                CreateBy = observationRequest.CreateBy,
                Remarks = observationRequest.Remarks,
                BrandlingForDispensingMachine = observationRequest.BrandlingForDispensingMachine,
                BrandlingForGyroshakerMachine = observationRequest.BrandlingForGyroshakerMachine,
                Status = 1,
            };
            tdrc.Observations.Add(ob);
            tdrc.SaveChanges();






        }
    }
}