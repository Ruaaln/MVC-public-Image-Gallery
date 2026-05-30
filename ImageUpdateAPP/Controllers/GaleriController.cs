using ImageUpdateAPP.Service;
using Microsoft.AspNetCore.Mvc;

namespace ImageUpdateAPP.Controllers
{
    public class GaleriController : Controller
    {

        #region Fields and Constructor
        private readonly FileService _fileService;

        public GaleriController(FileService fileService)
        {
            _fileService = fileService;
        }
        #endregion


        #region Index Action Method
        public IActionResult Index()
        {
            var images = _fileService.GetAllImages();
            return View(images);
        }
        #endregion

        #region Intro Action Method
        public IActionResult Intro()
        {
            return View();
        }
        #endregion

        #region Update Action Methods

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return View();

            var fileName = await _fileService.SaveImageAsync(file);

            return RedirectToAction("Index");
        } 

        #endregion

    }
}
