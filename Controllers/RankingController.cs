using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using WebApplication1.Models;
using WebApplication1.Views.Ranking;

namespace WebApplication1.Controllers
{
    public class RankingController : Controller
    {
        // GET: Ranking
        //ViewResult - representa o HTML gerado pela aplicação
        public ActionResult Index()
        {
            var modelo = RankingService.Instance().GetAll();
            return View(modelo);
        }
        [HttpGet]       
        public ActionResult NovoScore()
        {
            var modelo = new NewScoreViewModel();
            return View(modelo);
        }
        [HttpPost]
        public ActionResult NovoScore(Score input)
        {
            RankingService.Instance().Create(input);
            return Redirect("/Ranking");
        }


            //ViewBag.Id = 8;
            //ViewBag.Avatar = "‍🦸‍♀️";
            //ViewBag.PlayerName = "Renata C. Armel";
            //ViewBag.Points = 1298;

            
        
        // EmptyResult- Não representa nenhum resultado 
        public ActionResult Vazio()
        {
            return new EmptyResult();
        }

        //RedirectResult - Redireciona para outra URL da aplicação
        public ActionResult VaiPraHome()
        {
            return Redirect("/Home/Index");
        }
        
        //JsonResult - objeto na notação JSON
        public ActionResult Json()
        {
            var obj = new { id = 1234, nome = "Marcelo Silva" };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    
        //ContentResult - resultado de texto
        public ActionResult OlaMundo()
        {
            return Content("Olá, Mundo!");
        }

        //FileContentResult - arquivo para download
        public ActionResult Logo()
        {
           var path = Server.MapPath("~/Images/gama.png");
           var contentType = "data:image/png;base64, {0}";
           return File(path, contentType, "logo.png");
        }


    }


}