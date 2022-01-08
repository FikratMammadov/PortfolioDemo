using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class StatisticsController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        // GET: AdminStatistics
        public ActionResult Index()
        {
            var model = new StatisticsViewModel
            {
                CategoryCount = categoryManager.GetAll().Count,
                HeadingsByYazilimCategory = headingManager.HeadingsInYazilimCategory().Count,
                WritersContainA = writerManager.GetAllWritersContainA().Count,
                CategoryHasMostHeading = categoryManager.GetCategoryHasMostHeadings(),
                DifferenceBetweenStatus = categoryManager.DifferenceBetweenCategoryStatus()
            };
            return View(model);
        }
    }
}