﻿using MvcOnlineTicariOtomasyon.Models.Sınıflar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            var grafikciz = new Chart(600, 600);
            grafikciz.AddTitle("Kategori - Ürün Stok Sayısı").AddLegend("Stok").AddSeries("Değerler", xValue: new[] { "Mobilya", "Ofis Eşyaları", "Bilgisayar" }, yValues: new[] { 85, 66, 98 }).Write();
            return File(grafikciz.ToWebImage().GetBytes(), "image/jpeg");

        }


        Context c = new Context();
        public ActionResult Index3()
        {
            ArrayList xvalue = new ArrayList();
            ArrayList yvalue = new ArrayList();
            var sonuclar = c.Uruns.ToList();
            sonuclar.ToList().ForEach(x => xvalue.Add(x.UrunAd));
            sonuclar.ToList().ForEach(y => yvalue.Add(y.Stok));
            var grafik = new Chart(width: 800, height: 500)
                .AddTitle("Stoklar")
                .AddSeries(chartType: "Doughnut", name: "Stok", xValue: xvalue, yValues: yvalue);
            return File(grafik.ToWebImage().GetBytes(), "Image/jpeg");
        }

        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult VisualizeUrunResult()
        {
            return Json(UrunListesi(), JsonRequestBehavior.AllowGet);
        }
        public List<sinif1> UrunListesi()
        {
            List<sinif1> snf = new List<sinif1>();
            snf.Add(new sinif1()
            {
                UrunAd = "Bilgisayar",
                Stok = 120
            });
            snf.Add(new sinif1()
            {
                UrunAd = "Beyaz Eşya",
                Stok = 150
            });
            snf.Add(new sinif1()
            {
                UrunAd = "Mobilya",
                Stok = 70
            });
            snf.Add(new sinif1()
            {
                UrunAd = "Küçük Ev Aletleri",
                Stok = 180
            });
            snf.Add(new sinif1()
            {
                UrunAd = "Mobil Cihazlar",
                Stok = 95
            });
            return snf;
        }
        public ActionResult Index5()
        {
            return View();
        }
        public ActionResult VisualizeUrunResult2()
        {
            return Json(UrunListesi2(), JsonRequestBehavior.AllowGet);
        }

        public List<sinif2> UrunListesi2()
        {
            List<sinif2> snf = new List<sinif2>();
            using (var context = new Context())
            {
                snf = c.Uruns.Select(x => new sinif2
                {
                    Urn = x.UrunAd,
                    Stk = x.Stok
                }).ToList();
            }
            return snf;
        }
        public ActionResult Index6()
        {
            return View();
        }
        public ActionResult Index7()
        {
            return View();
        }
    }

}
