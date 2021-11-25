namespace Gluon.Event
{
	public class RequiredAttribute : ValidationAttribute
	{
		public override bool IsValid(object o)
		{
			return default(bool);
		}
	}
}
