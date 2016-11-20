using System;
using System.IO;
using System.Web.Mvc;

namespace SocialApps.Controllers
{
    [Authorize]
    public partial class MobileController : PersonalizedController
    {
        protected override void Dispose(bool disposing)
        {
        }

        //  https://action.mindjet.com/task/14501416
        public ActionResult Index()
        {
            try
            {
                /*
                using (FileStream file = new FileStream(Server.MapPath(Url.Content("~/Content/desktop.html")), FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[file.Length];
                    file.Read(bytes, 0, (int)file.Length);
                    return File(bytes, System.Net.Mime.MediaTypeNames.Text.Html);
                }
                */
                return View("Desktop");
            }
            catch (Exception e)
            {
                Application_Error(e);
                return View("Error", new HandleErrorInfo(e, "Mobile", "Index"));
            }
        }

        public ActionResult Menu()
        {
            try
            {
                ViewBag.Message = "Welcome to Desktop!";
                //  https://www.evernote.com/shard/s132/nl/14501366/14e369f7-348f-4f68-aa65-6a5e7dda1da7
                var date = DateTime.Now;
                ViewBag.Month = date.Month;
                ViewBag.Year = date.Year;

                //  https://www.evernote.com/shard/s132/nl/14501366/c707248c-3cab-47d7-838a-ec2b791e4ea7
                if (User.IsInRole("User") || User.IsInRole("Administrator"))
                {
                }

                return View();
            }
            catch (Exception e)
            {
                Application_Error(e);
                return View("Error", new HandleErrorInfo(e, "Mobile", "Menu"));
            }
        }

        public ActionResult About()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                Application_Error(e);
                return View("Error", new HandleErrorInfo(e, "Mobile", "About"));
            }
        }

        public ActionResult Contribute()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                Application_Error(e);
                return View("Error", new HandleErrorInfo(e, "Mobile", "Contribute"));
            }
        }

        public static string MonthYearToString(int month, int year)
        {
            var date = new DateTime(year, month, 1);
            return date.ToString("MMM yyyy");
        }

        //  https://www.evernote.com/shard/s132/nl/14501366/83a03e66-6551-43c0-816e-2b32be9640df
        public ActionResult Error()
        {
            try
            {
                return View();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
