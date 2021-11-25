using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsEnemyAbility : ActionParts
	{
		[SerializeField]
		private EnemyAbilityData _data;

		public override PartsData data => null;
	}
}
