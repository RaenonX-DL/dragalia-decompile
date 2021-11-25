namespace Gluon
{
	public class SimpleState
	{
		public delegate void SimpleStateDelegateBegin(SimpleState prev);

		public delegate void SimpleStateDelegateEnd(SimpleState next);

		public delegate void SimpleStateDelegateTick();

		public SimpleStateDelegateBegin eventBegin;

		public SimpleStateDelegateEnd eventEnd;

		public SimpleStateDelegateTick eventTick;

		private string name;

		public SimpleState(string _name)
		{
		}

		public string Name()
		{
			return null;
		}
	}
}
