using IlyaCourseWork.DB.Entity;
using IlyaCourseWork.DB.Repositories.Interfaces;
using IlyaCourseWork.Dictionaries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IlyaCourseWork.Controllers
{
    public class PagesController : Controller
    {
        public readonly IBaseRepository<About> _aboutRepository;
        public readonly IBaseRepository<Media> _mediaRepository;
        public readonly IBaseRepository<Career> _careerRepository;
        public readonly IBaseRepository<Products> _productsRepository;

        public PagesController(IBaseRepository<About> aboutRepository, IBaseRepository<Media> mediaRepository, IBaseRepository<Career> careerRepository, IBaseRepository<Products> productsRepository)
        {
            _aboutRepository = aboutRepository;
            _mediaRepository = mediaRepository;
            _careerRepository = careerRepository;
            _productsRepository = productsRepository;
        }

        [Route("About/{name}")]
        public async Task<IActionResult> LoadAbout(string name)
        {
            var response = _aboutRepository.GetAll();
                var xui = await response.FirstOrDefaultAsync(about => about.PageName == name);
            if (response is null)
                return View();

            ViewData["Title"] = Dict.GetValue(xui.PageName);
            return View("Template", (object)xui.HTMLCode);
        }

        [Route("Media/{name}")]
        public async Task<IActionResult> LoadMedia(string name)
        {
            var response = await _mediaRepository.GetAll().FirstOrDefaultAsync(media => media.PageName == name);
            if (response is null)
                return View();

            ViewData["Title"] = Dict.GetValue(response.PageName);
            return View("Template", (object)response.HTMLCode);
        }

        [Route("Career/{name}")]
        public async Task<IActionResult> LoadCareer(string name)
        {
            var response = await _careerRepository.GetAll().FirstOrDefaultAsync(career => career.PageName == name);
            if (response is null)
                return View();

            ViewData["Title"] = Dict.GetValue(response.PageName);
            return View("Template", (object)response.HTMLCode);
        }

        [Route("Products/{name}")]
        public async Task<IActionResult> LoadProducts(string name)
        {
            var response = await _productsRepository.GetAll().FirstOrDefaultAsync(products => products.PageName == name);
            if (response is null)
                return View();

            ViewData["Title"] = Dict.GetValue(response.PageName);
            return View("Template", (object)response.HTMLCode);
        }
    }
}
