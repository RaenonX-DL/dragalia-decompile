using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsEventAction : ActionParts
	{
		[SerializeField]
		private EventActionData _data;

		public override PartsData data => null;
	}
}
