using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsLoitering : ActionParts
	{
		[SerializeField]
		private LoiteringData _data;

		public override PartsData data => null;
	}
}
