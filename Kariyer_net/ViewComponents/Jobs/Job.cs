using System;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer_net.ViewComponents.Jobs
{

	//ViewComponent classı bizim oluşturduğumuz bir class değil.Asp.netCore yapısının kendisine ait olan bir yapısı.
	public class Job:ViewComponent
	{
		public IViewComponentResult Invoke()
		{


			return View();
		}


	}
}

