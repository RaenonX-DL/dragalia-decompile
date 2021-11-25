using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsUnison : ActionParts
	{
		public enum UnisonType
		{
			OnSite,
			SamePosition,
			AreaAnchor,
			DiagonalLine
		}

		private readonly UnisonData _partsData;

		public ActionPartsUnison(Gluon.ActionData.ActionParts resource)
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

		private void OrderAction(EnemyCharacter chara, int actionId)
		{
		}

		private void SetPosition(EnemyAbilityProcUnison ability)
		{
		}

		private void SetPositionDiagonal(EnemyAbilityProcUnison ability, Transform primaryTransform, Transform secondaryTransform)
		{
		}

		private CharacterBase GetTarget()
		{
			return null;
		}
	}
}
