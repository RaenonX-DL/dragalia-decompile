using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsOrderToSub : ActionParts
	{
		private readonly OrderToSubData _partsData;

		public List<EnemyCharacter> _subCharaList;

		public ActionPartsOrderToSub(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		private void ProcCommand()
		{
		}

		private void OrderAction(EnemyCharacter chara)
		{
		}

		private void TargetCorrection(ref CommonObjectStatus target)
		{
		}
	}
}
