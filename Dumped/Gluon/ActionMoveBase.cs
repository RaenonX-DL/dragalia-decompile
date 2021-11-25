namespace Gluon
{
	public class ActionMoveBase : ActionInterval
	{
		public enum PropertyType
		{
			PushOut = 1,
			AutoDash = 2,
			ForcedMove = 4,
			ChargeMove = 8,
			ThroughChara = 0x10
		}

		protected int _property;

		protected int prevLayer;

		protected bool IsProperty(PropertyType type)
		{
			return default(bool);
		}

		protected void SetPrevLayer()
		{
		}

		protected void ResetLayer()
		{
		}
	}
}
