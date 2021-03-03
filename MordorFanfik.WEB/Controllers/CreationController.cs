using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MordorFanfik.WEB.Models;
using MordorFanfik.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc.Html;

namespace MordorFanfik.WEB.Controllers
{
    public class CreationController : Controller
    {
        public IActionResult Creation(CreateCreationViewModel model)
        {
            ViewBag.Genre = Enum.GetValues(typeof(Genre));
            return View(model);
        }

        public IActionResult Chapter(CreateChapterViewModel model)
        {
            return View(model);
        }
    }
}
