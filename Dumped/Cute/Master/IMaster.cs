namespace Cute.Master
{
	public abstract class IMaster<U> : IMasterBase where U : IMasterBase
	{
		private static U instance;

		public static U Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public static void Clear()
		{
		}
	}
}
