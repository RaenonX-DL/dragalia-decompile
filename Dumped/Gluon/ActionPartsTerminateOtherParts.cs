using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsTerminateOtherParts : ActionParts
	{
		private readonly TerminateOtherData _partsData;

		private Gluon.ActionData.ActionParts.PartsData.ConditionData partConditionData;

		public ActionPartsTerminateOtherParts(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
