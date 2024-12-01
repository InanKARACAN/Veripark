using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Veripark.Entity.Entities;
using Veripark.Service.Services.Abstractions;
using Veripark.Web.Models;

namespace Veripark.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMusteriTipService musteriTipService;
        private readonly IOlayTipService olayTipService;
        private readonly ISikayetService sikayetService;

        public HomeController(IMusteriTipService musteriTipService, IOlayTipService olayTipService, ISikayetService sikayetService)
        {
            this.musteriTipService = musteriTipService;
            this.olayTipService = olayTipService;
            this.sikayetService = sikayetService;
        }

        public async Task<IActionResult> Index()
        {
            var olayTipleri = await olayTipService.GetAllOlayTipAsync();

            IEnumerable<SelectListItem> itemsOlayTipleri = olayTipleri.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.OlayTipAdi
            });

            ViewBag.olayTipleri = itemsOlayTipleri;


            var musteriTipleri = await musteriTipService.GetAllMusteriTipAsync();

            IEnumerable<SelectListItem> itemsmusteriTipleri = musteriTipleri.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.MusteriTipAdi
            });

            ViewBag.musteriTipleri = itemsmusteriTipleri;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SikayetEkle(Sikayet model)
        {
            if (ModelState.IsValid)
            {
                string mesaj;
                var sonuc = await sikayetService.SikayetEkle(model);
                if (sonuc)
                    mesaj = "Ekleme Başarılı";
                else
                    mesaj = "Ekleme Başarısız";

            }
            return View("Index");
        }

            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}