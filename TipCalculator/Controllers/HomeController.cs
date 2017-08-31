using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
        public ActionResult Index()
        {
            return View();
        }

		//[HttpGet]
		//public ActionResult TipCalculator()
		//{
		//	return View("TipCalculator");
		//}

		[HttpPost]
		public ActionResult TipCalculator(TipCalculations model)
		{
			//if ( ModelState.IsValidField("BillAmount") )
			//{
			//	if ( model.BillAmount <=0 )
			//	{
			//		ModelState.AddModelError("BillAmount",
			//		"Bill amount must be greater than 0");
			//	}
				
			//}
			//else
			//{
			//	ModelState.AddModelError("BillAmount",
			//	"Please enter a valid dollar amount for the bill amount");
			//}

			//if ( ModelState.IsValidField("Tip") )
			//{
			//	if ( model.Tip <= 0 )
			//	{
			//		ModelState.AddModelError("Tip",
			//		"Tip percentage must be greater than 0");
			//	}
			//}
			//else
			//{
			//	ModelState.AddModelError("Tip",
			//	"Please enter a valid tip percentage");
			//}

			//if ( ModelState.IsValidField("NumberOfPeople") )
			//{
			//	if ( model.NumberOfPeople < 1)
			//	{
			//		ModelState.AddModelError("NumberOfPeople",
			//		"Number of people must be at least 1");
			//	}
			//}
			//else
			//{
			//	ModelState.AddModelError("NumberOfPeople",
			//	"Please enter a valid number of people");
			//}

			if ( ModelState.IsValid )
			{
				model.TotalTip = Math.Round((model.BillAmount * (model.Tip / 100)), 2);

				model.TipPerPerson = Math.Round(model.TotalTip / model.NumberOfPeople, 2);
				model.TotalBill = model.BillAmount + model.TotalTip;

				decimal evenTip = model.TotalTip - model.NumberOfPeople * model.TipPerPerson;

				if ( evenTip != 0 )
				{
					model.TotalBill -= evenTip;
					model.TotalTip -= evenTip;
				}
				// return PartialView("TipCalculator", model);
				return View("TipCalculator", model);
			}
			else
			{
				// send them back to the entry form
				return View("Index", model);
			}
	
		}

		[HttpPost]
		public PartialViewResult TipCalculator2(TipCalculations model)
		{

			if ( ModelState.IsValid )
			{
				model.TotalTip = Math.Round((model.BillAmount * (model.Tip / 100)), 2);

				model.TipPerPerson = Math.Round(model.TotalTip / model.NumberOfPeople, 2);
				model.TotalBill = model.BillAmount + model.TotalTip;

				decimal evenTip = model.TotalTip - model.NumberOfPeople * model.TipPerPerson;

				if ( evenTip != 0 )
				{
					model.TotalBill -= evenTip;
					model.TotalTip -= evenTip;
				}
				//return PartialView("TipCalculator2", model);
				// return View("TipCalculator", model);
			}
			//else
			//{
			//	// send them back to the entry form
			//	return View("Index", model);
			//}
			return PartialView("TipCalculator2", model);
		}
	}
}