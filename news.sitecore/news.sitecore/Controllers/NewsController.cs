using news.sitecore.Application.Services;
using Newtonsoft.Json;
using Sitecore;
using System.Web;
using System.Web.Mvc;

namespace news.sitecore.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;

        }
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewsArticle()
        {
            var model = _newsService.GetNewsViewModel();
            if (model == null && (Context.Page == null || !Context.PageMode.IsExperienceEditor))
            {
                throw new HttpException((int)System.Net.HttpStatusCode.NotFound, $"Model is null for rendering. Article does not exist");
            }

            return View(model);
        }
        public JsonResult SearchNews(string id)
        {            
            var result = _newsService.SearchNews(id);
            Response.ContentType = "application/json";
            var jsonSer = JsonConvert.SerializeObject(result); ;

            return Json(jsonSer, JsonRequestBehavior.AllowGet);
        }
    }
}