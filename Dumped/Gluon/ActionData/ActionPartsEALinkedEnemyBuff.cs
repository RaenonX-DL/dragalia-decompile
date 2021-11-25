using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsEALinkedEnemyBuff : ActionParts
	{
		[SerializeField]
		private EALinkedEnemyBuffData _data;

		public override PartsData data => null;
	}
}
