using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsCommandMultiWeak : ActionParts
	{
		public enum CommandType
		{
			SelectAction,
			Cancel,
			AdjustIcon,
			TurnAllWeak
		}

		private readonly CommandMultiWeakData _partsData;

		public ActionPartsCommandMultiWeak(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		private void Proc()
		{
		}
	}
}
