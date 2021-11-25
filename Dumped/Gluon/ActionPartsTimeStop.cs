using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsTimeStop : ActionParts
	{
		public enum SwitchingType
		{
			OFF,
			ON
		}

		private readonly TimeStopData _partsData;

		public ActionPartsTimeStop(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		private void Procedure()
		{
		}
	}
}
