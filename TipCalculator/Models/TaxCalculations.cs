using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TipCalculator.Attributes;

namespace TipCalculator.Models
{
	public class TipCalculations
	{
		// input 
		[Display(Name = "Bill Amount")]
		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
		[DataType(DataType.Currency )]
		[Required(ErrorMessage ="Please enter the bill amount")]
		[IsGreaterThanZero(ErrorMessage = "Bill amount must be greater than 0")]
		public decimal BillAmount { get; set; }

		[Display(Name = "Tip Percentage")]
		[DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage = "Please enter the tip percentage")]
		[IsGreaterThanZero(ErrorMessage = "Tip percentage must be greater than 0")]
		public decimal Tip { get; set; }

		[Display(Name = "Number of People")]
		[DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage = "Please enter the number of people")]
		[IsGreaterThanZero(ErrorMessage = "The number of people must be greater than 0")]
		public int NumberOfPeople { get; set; }

		// Calculated values
		[Display(Name = "Total Tip")]
		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
		public decimal TotalTip { get; set; }

		[Display(Name = "Rounded Up Tip")]
		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
		public decimal RoundedUpTip { get; set; }

		[Display(Name = "Tip Per Person")]
		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
		public decimal TipPerPerson { get; set; }

		[Display(Name = "Rounded Up Tip per Person")]
		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
		public decimal RoundedTipPerPerson { get; set; }

		[Display(Name = "Total Bill")]
		[DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
		public decimal TotalBill { get; set; }
	}
}