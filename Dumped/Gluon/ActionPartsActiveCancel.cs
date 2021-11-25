using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsActiveCancel : ActionParts
	{
		public enum ActionType
		{
			None,
			BurstAttack,
			Avoid,
			AvoidFront,
			AvoidBack,
			AnyCombo
		}

		private readonly ActiveCancelData _partsData;

		private bool isStart;

		private List<int> activeCancelActions;

		public ActionPartsActiveCancel(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		public static int[] GetActionsByActionType(CharacterBase owner, ActionType actionType)
		{
			return null;
		}

		private void AnalyzeActionType()
		{
		}
	}
}
