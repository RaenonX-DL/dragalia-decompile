namespace XLua.Cast
{
	public class Any<T> : RawObject
	{
		private T mTarget;

		public object Target => null;

		public Any(T i)
		{
		}
	}
}
