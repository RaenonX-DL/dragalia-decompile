using System;

namespace Gluon.Event
{
	public class ValidationAttribute : Attribute
	{
		public virtual bool IsValid(object o)
		{
			return default(bool);
		}
	}
}
