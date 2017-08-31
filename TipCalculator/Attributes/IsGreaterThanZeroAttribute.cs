using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TipCalculator.Attributes
{
	public class IsGreaterThanZeroAttribute : ValidationAttribute
	{
	
		public override bool IsValid(object value)
		{
			if ( value is int )
			{
				if ( (int)value > 0 )
					return true;
				else
					return false;
			}
			if ( value is decimal )
			{
				if ( (decimal)value > 0M )
					return true;
				else
					return false;
			}
			// value is not a numeric type, fail
			return false;
		}
	}
}