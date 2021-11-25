using UnityEngine;

namespace Gluon.ActionData
{
	public class ActionPartsVolcano : ActionParts
	{
		[SerializeField]
		private VolcanoData _data;

		public override PartsData data => null;
	}
}
