using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsGameMasterEvent : ActionParts
	{
		[SerializeField]
		private GameMasterEventData _data;

		public override PartsData data => null;
	}
}
