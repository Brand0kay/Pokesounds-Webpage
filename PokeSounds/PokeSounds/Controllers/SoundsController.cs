using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeSounds.Models;
using PokeSounds.DAL;
using Microsoft.AspNetCore.Hosting;

namespace PokeSounds.Controllers
{
    public class SoundsController : Controller
    {
        //    private readonly IHostingEnvironment _hostingEnvironment;

        //    public SoundsController(IHostingEnvironment hostingEnvironment)
        //    {
        //        _hostingEnvironment = hostingEnvironment;
        //    }



        public IActionResult Index()
        {
            IPokeSoundsDAL pokeSoundsDAL = new PokeSoundsDAL();

            IList<Pokemon> sounds = pokeSoundsDAL.GetSounds();

            //string webRootPath = _hostingEnvironment.WebRootPath;
            //string contentRootPath = _hostingEnvironment.ContentRootPath;

            //return Content(webRootPath + "\n" + contentRootPath);

            return View(sounds);
        }

        //public IActionResult Detail(string id)
        //{
        //    IPokeSoundsDAL pokeSoundsDAL
        //}

    }
}


