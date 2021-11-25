using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsRemoveBuffTriggerBomb : ActionParts
	{
		[SerializeField]
		private RemoveBuffTriggerBombData _data;

		public override PartsData data => null;
	}
}
