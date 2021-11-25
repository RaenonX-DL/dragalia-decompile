using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsSyncCharacterPosition : ActionParts
	{
		[SerializeField]
		private SyncCharacterPositionData _data;

		public override PartsData data => null;
	}
}
