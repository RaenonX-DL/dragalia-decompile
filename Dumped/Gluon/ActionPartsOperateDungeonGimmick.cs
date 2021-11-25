using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsOperateDungeonGimmick : ActionParts
	{
		public enum GimmickType
		{
			Warp
		}

		public enum OperateType
		{
			Activate,
			Deactivate,
			ForcingWarp
		}

		public enum WarpTarget
		{
			Self,
			AllUnit,
			OnlyPassEntrance
		}

		private readonly OperateDungeonGimmickData _partsData;

		private List<CharacterBase> _listWarpTarget;

		public ActionPartsOperateDungeonGimmick(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		private void Proc()
		{
		}

		private void ProcWarp()
		{
		}

		private void ListWarpTarget()
		{
		}
	}
}
