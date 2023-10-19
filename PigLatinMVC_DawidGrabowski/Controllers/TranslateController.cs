using PigLatinMVC_DawidGrabowski.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PigLatinMVC_DawidGrabowski.Controllers
{
    public class TranslateController : Controller
    {
        // GET: Translates
        public ActionResult Translate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Translate(English_PigLatin model)
        {
            if (ModelState.IsValid)
            {
                TranslatePigLatin translate = new TranslatePigLatin();

                string english = model.English_text;
                string pigLatin = translate.Translate(english);

                model.PigLatin_text = pigLatin;
            }

            return View("DisplayPigLatin", model);
        }
    }
}