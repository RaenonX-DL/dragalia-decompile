using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsIgnoreEnemyPush : ActionParts
	{
		[SerializeField]
		private IgnoreEnemyPushData _data;

		public override PartsData data => null;
	}
}
