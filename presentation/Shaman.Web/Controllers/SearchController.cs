using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShamanKing;

namespace Shaman.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IEpisodeRepository episodeRepository;
        public SearchController(IEpisodeRepository episodeRepository)
        {
            this.episodeRepository = episodeRepository;
        }

        public IActionResult Index(string query)
        {
            var episodes = episodeRepository.GetAllByTitle(query);
            return View(episodes);
        }
    }
}
