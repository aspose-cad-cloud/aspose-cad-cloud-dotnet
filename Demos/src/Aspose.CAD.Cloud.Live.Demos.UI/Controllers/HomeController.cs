using Aspose.CAD.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.CAD.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = Resources["cadConversionPageTitle"];
			ViewBag.MetaDescription = Resources["cadConversionMetaDescription"];

			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
